using Bartender.Net.Framework;
using Bartender.Net.Framework.REST;
using Bartender.Net.Framework.Section;
using Bartender.Net.Key;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace Bartender.Net.REST;

/// <summary>
/// A request client to interact with Torn's REST Api.
/// </summary>
public class ApiRequestClient : IApiRequestClient {
    private readonly HttpClient _client;

    public ApiRequestClient (IHttpClientFactory clientFactory, string apiUrl) {
        _client = clientFactory.CreateClient ();

        _client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

        _client.BaseAddress = new Uri (apiUrl);
    }

    public async Task<IApiResponse<T>> FetchSelectionAsync<T> (IRequestConfiguration requestConfiguration) {
        if (requestConfiguration.Selections.Count > 1) {
            throw new ArgumentException ("Use FetchMultipleSelectionsAsync to fetch more than one selection at a time");
        }

        var result = new ApiResponse<T> {
            HttpResponseMessage = await _client.GetAsync (requestConfiguration.ToString ())
        };

        if (!result.HttpResponseMessage.IsSuccessStatusCode) {
            return result;
        }

        var json = await result.HttpResponseMessage.Content.ReadAsStringAsync ();

        if (json == string.Empty) {
            return result;
        }

        try {
            var parsed = JsonConvert.DeserializeObject<T> (json);

            result.Content = parsed;
        }
        catch (JsonException) {
            result.Content = default;
            return result;
        }

        return result;
    }

    public async Task<IApiResponse<IEnumerable<object>>> FetchMultipleSelectionsAsync (IRequestConfiguration requestConfiguration) {
        var result = new ApiResponse<IEnumerable<object>> {
            HttpResponseMessage = await _client.GetAsync (requestConfiguration.ToString ())
        };

        if (!result.HttpResponseMessage.IsSuccessStatusCode) {
            return result;
        }

        var json = await result.HttpResponseMessage.Content.ReadAsStringAsync ();

        if (json == string.Empty) {
            return result;
        }

        var fetched = new List<object> ();

        foreach (var selection in requestConfiguration.Selections) {
            try {
                var parsed = JsonConvert.DeserializeObject (json, selection.Root);

                if (parsed is not null) {
                    fetched.Add (parsed);
                }
            }
            catch (JsonException) {
                continue;
            }
        }

        result.Content = fetched;

        return result;
    }

    public async Task<IKeyValidationStatus> ValidateKeyForSelectionAsync (string key, Selection selection) {
        var config = new RequestConfiguration {
            Key = key,
            Section = "key",
            Selections = ["info"],
            Comment = "Bartender.Net Key Validation"
        };

        var response = await _client.GetAsync (config.ToString ());

        if (!response.IsSuccessStatusCode) {
            return new KeyValidationStatus {
                HttpStatusCode = response.StatusCode
            };
        }

        var json = await response.Content.ReadAsStringAsync ();

        if (json == string.Empty) {
            return new KeyValidationStatus {
                HttpStatusCode = HttpStatusCode.NotFound
            };
        }

        var error = ParseErrorCode (json);

        if (error >= 0) {
            return new KeyValidationStatus {
                ErrorCode = error,
            };
        }

        var parsed = JsonConvert.DeserializeObject<KeyInfo> (json);

        if (parsed is null) {
            return new KeyValidationStatus ();
        }

        if (parsed.AccessLevel < selection.AccessLevelRequired) {
            return new KeyValidationStatus {
                IsValid = true,
                ErrorCode = 16,
            };
        }

        return new KeyValidationStatus {
            IsValid = true,
            HasRequiredAccessLevel = true,
            ErrorCode = -1
        };
    }

    private static int ParseErrorCode (string json) {
        var parsed = JsonConvert.DeserializeObject<ResponseError> (json);

        return parsed is null || parsed.Error is null ? -1 : parsed.Error.Code;
    }

    private class FetchResult<T> {
        public int ErrorCode { get; set; }
        public required T Result { get; set; }
    }
}

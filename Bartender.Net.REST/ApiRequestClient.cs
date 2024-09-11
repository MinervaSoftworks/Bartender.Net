using Bartender.Net.Framework;
using Bartender.Net.Framework.REST;
using Bartender.Net.Framework.Section;
using Bartender.Net.Key;
using Newtonsoft.Json;
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

    public async Task<IApiResponse> FetchAsync (IRequestConfiguration requestConfiguration) {
        var result = new ApiResponse {
            HttpResponseMessage = await _client.GetAsync (requestConfiguration.ToString ())
        };

        if (!result.HttpResponseMessage.IsSuccessStatusCode) {
            return result;
        }

        var json = await result.HttpResponseMessage.Content.ReadAsStringAsync ();

        if (json == string.Empty) {
            result.Error = 17;

            return result;
        }

        var error = ParseErrorCode (json);

        if (error >= 0) {
            result.Error = error;

            return result;
        }

        var fetched = new Dictionary<Selection, object> ();

        foreach (var selection in requestConfiguration.Selections) {
            try {
                var parsed = JsonConvert.DeserializeObject (json, selection.Root);

                if (parsed is not null) {
                    fetched.Add (selection, parsed);
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
            Selections = [KeySection.Info],
            Comment = "Bartender.Net Key Validation"
        };

        var response = await FetchAsync (config);

        var status = new KeyValidationStatus {
            Response = response
        };

        if (response is null || response.HttpResponseMessage is null) {
            return status;
        }

        if (response.Error >= 0) {
            return status;
        }

        var keyInfo = response.Content [KeySection.Info] as KeyInfo;

        if (keyInfo is null) {
            return status;
        }

        status.IsValid = true;
        status.HasRequiredAccessLevel = keyInfo.Selections.HasSelectionAccess (selection.Name);

        return status;
    }

    private static int ParseErrorCode (string json) {
        var parsed = JsonConvert.DeserializeObject<ResponseError> (json);

        return parsed is null || parsed.Error is null ? -1 : parsed.Error.Code;
    }
}

using Bartender.Net.Framework;
using Bartender.Net.Framework.REST;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Key;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Bartender.Net.REST;

/// <summary>
/// A request client to interact with Torn's REST Api.
/// </summary>
public class ApiRequestClient : IApiRequestClient {
    private readonly int _fetchTimeLimit = 500;
    private readonly int _retries = 5;
    private readonly int _retryTimeout = 2500;

    private DateTime _lastFetch = DateTime.UtcNow;

    private TimeSpan _timeSinceLastFetch = new TimeSpan ();

    private static object _lock = new object ();

    private readonly HttpClient _client;

    public ApiRequestClient (IHttpClientFactory clientFactory, string apiUrl, int fetchTimeLimit = 500, int retries = 5, int retryTimeout = 5000) {
        _client = clientFactory.CreateClient ();

        _client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

        _client.BaseAddress = new Uri (apiUrl);

        _fetchTimeLimit = fetchTimeLimit;
        _retries = retries;
        _retryTimeout = retryTimeout;
    }

    private static int ParseErrorCode (string json) {
        var parsed = JsonConvert.DeserializeObject<ResponseError> (json);

        return parsed is null || parsed.Error is null ? -1 : parsed.Error.Code;
    }

    private bool CanFetch () {
        lock (_lock) {
            _timeSinceLastFetch = DateTime.UtcNow - _lastFetch;

            return _timeSinceLastFetch.Milliseconds > _fetchTimeLimit;
        }
    }

    private async Task<HttpResponseMessage> PerformFetchAsync (IRequestConfiguration requestConfiguration) {
        if (!CanFetch ()) {
            await Task.Delay (400 - _timeSinceLastFetch.Milliseconds);
        }

        _lastFetch = DateTime.UtcNow;

        return await _client.GetAsync (requestConfiguration.ToString ());
    }

    public async Task<IApiResponse> FetchAsync (IRequestConfiguration requestConfiguration) {
        var result = new ApiResponse {
            HttpResponseMessage = await PerformFetchAsync (requestConfiguration)
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
                var parsed = JsonConvert.DeserializeObject (json, selection.JsonRootType);

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

    public async Task<ISingleSelectionApiResponse<T>> FetchSingleSelectionAsync<T> (IRequestConfiguration requestConfiguration) where T : BartenderEntity {
        var result = new SingleSelectionApiResponse<T> {
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

        result.Content = JsonConvert.DeserializeObject<T> (json);

        return result;
    }

    public async Task<IKeyValidationStatus> ValidateKeyForSelectionAsync (string key, Selection selection) {
        var config = new RequestConfiguration {
            Key = key,
            Section = "key",
            Selections = [KeySection.Instance.Info],
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

        var keyInfo = response.Content [KeySection.Instance.Info] as KeyInfo;

        if (keyInfo is null) {
            return status;
        }

        status.IsValid = true;
        status.HasRequiredAccessLevel = keyInfo.Selections.HasSelectionAccess (selection.Name);

        return status;
    }
}

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
    private readonly HttpClient _client;

    public ApiRequestClient (HttpClient client, IApiUrl apiUrl) {
        _client = client;

        _client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

        _client.BaseAddress = new Uri (apiUrl.BaseUrl);
    }

    public async Task<IApiResponse> FetchAsync (IRequestConfiguration requestConfiguration) {
        var result = await ExecuteFetchAsync (requestConfiguration);

        var fetched = new Dictionary<Selection, object> ();

        foreach (var selection in requestConfiguration.Selections) {
            try {
                var parsed = JsonConvert.DeserializeObject (result.Json, selection.JsonRootType);

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

    public async Task<IApiResponse> FetchSingleSelectionAsync (IRequestConfiguration requestConfiguration) {
        var result = await ExecuteFetchAsync (requestConfiguration);

        result.Content = JsonConvert.DeserializeObject (result.Json, requestConfiguration.Selections [0].JsonRootType);

        return result;
    }

    public async Task<IKeyValidationStatus> ValidateKeyForSelectionAsync (string key, Selection selection) {
        var config = new RequestConfiguration {
            Key = key,
            Section = KeySection.Instance,
            Selections = [KeySection.Instance.KeyInfo],
            Comment = "Bartender.Net Key Validation"
        };

        var result = await FetchAsync (config);

        var status = new KeyValidationStatus {
            Result = result
        };

        if (result is null || result.HttpResponseMessage is null) {
            return status;
        }

        if (result.Error >= 0) {
            return status;
        }

        if (result.Content is not KeyInfo keyInfo) {
            return status;
        }

        status.IsValid = true;
        status.HasRequiredAccessLevel = keyInfo.Selections.HasSelectionAccess (selection.Name);

        return status;
    }

    private async Task<IApiResponse> ExecuteFetchAsync (IRequestConfiguration requestConfiguration) {
        var result = new ApiResponse {
            HttpResponseMessage = await _client.GetAsync (requestConfiguration.ToString ())
        };

        if (result.HttpResponseMessage is null || !result.HttpResponseMessage.IsSuccessStatusCode) {
            result.Error = 17;
            return result;
        }

        var json = await result.HttpResponseMessage.Content.ReadAsStringAsync ();

        if (json == string.Empty) {
            result.Error = 17;
        }

        result.Json = json;
        result.Error = ParseErrorCode (json);

        return result;
    }

    private static int ParseErrorCode (string json) {
        var parsed = JsonConvert.DeserializeObject<ResponseError> (json);

        return parsed is null || parsed.Error is null ? -1 : parsed.Error.Code;
    }
}

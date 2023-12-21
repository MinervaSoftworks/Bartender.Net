using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using TornApi.Net.Models.Common;
using TornApi.Net.Models.Key;

namespace TornApi.Net.REST {
    /// <summary>
    /// A request client to interact with Torn's REST Api.
    /// </summary>
    public class ApiRequestClient {
        private HttpClient _client;

        public ApiRequestClient (IHttpClientFactory clientFactory, string apiUrl) {
            _client = clientFactory.CreateClient ();

            _client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

            _client.BaseAddress = new Uri (apiUrl);
        }

        public async Task<ApiResponse<T>> GetSingleObjectAsync<T> (RequestConfiguration config, AccessLevel accessLevel) where T : class {
            var keyStatus = await ValidateKeyAsync (config.Key, accessLevel);

            var result = new ApiResponse<T> {
                KeyStatus = keyStatus
            };

            if (!keyStatus.IsValid && !keyStatus.HasRequiredAccessLevel) {
                return result;
            }

            var response = await _client.GetAsync (config.ToString ());

            result.HttpResponseMessage = response;

            if (!response.IsSuccessStatusCode) {
                return result;
            }

            var json = await response.Content.ReadAsStringAsync ();

            if (json == string.Empty) {
                return result;
            }

            var parsed = JsonConvert.DeserializeObject<T> (json);

            result.Content = parsed;

            return result;
        }

        public async Task<KeyValidationStatus> ValidateKeyAsync (string key, AccessLevel requiredLevel) {
            var config = new RequestConfiguration {
                Key = key,
                Section = "key",
                Selections = ["info"],
                Comment = "TornApi.Net Key Validation"
            };

            var status = new KeyValidationStatus ();

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

            if (parsed.AccessType < requiredLevel) {
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

        private int ParseErrorCode (string json) {
            try {
                var parsed = JsonConvert.DeserializeObject<ResponseError> (json);
                return parsed is null ? -1 : parsed.Error.Code;
            }
            catch {
                return -1;
            }
        }
    }
}

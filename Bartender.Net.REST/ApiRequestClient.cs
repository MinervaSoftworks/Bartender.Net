using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace TornApi.Net.REST {
    /// <summary>
    /// A request client to interact with Torn's REST Api.
    /// </summary>
    public class ApiRequestClient : IApiRequestClient {
        private HttpClient _client;

        private DateTime _lastUpdateFetch = DateTime.UtcNow;
        private int _fetchDelayMiliseconds = 600;

        private SemaphoreSlim _clockSemaphore = new SemaphoreSlim (1, 1);

        public ApiRequestClient (IHttpClientFactory clientFactory, string apiUrl) {
            _client = clientFactory.CreateClient ();

            _client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

            _client.BaseAddress = new Uri (apiUrl);
        }

        public async Task<IApiResponse<T>?> GetAsync<T> (RequestConfiguration config, AccessLevel accessLevel) where T : class {
            var keyStatus = await ValidateKeyAsync (config.Key, accessLevel);

            var result = new ApiResponse<T> {
                KeyStatus = keyStatus
            };

            if (!keyStatus.IsValid && !keyStatus.HasRequiredAccessLevel) {
                return result;
            }
            _clockSemaphore.Wait ();
            int milisecondsSinceLastFetch = (int) (DateTime.UtcNow - _lastUpdateFetch).TotalMilliseconds;

            if (milisecondsSinceLastFetch < _fetchDelayMiliseconds) {
                await Task.Delay (_fetchDelayMiliseconds - milisecondsSinceLastFetch);
                _lastUpdateFetch = DateTime.UtcNow;
            }
            _clockSemaphore.Release ();

            var response = await _client.GetAsync (config.ToString ());

            result.HttpResponseMessage = response;

            if (!response.IsSuccessStatusCode) {
                return result;
            }

            var json = await response.Content.ReadAsStringAsync ();

            if (json == string.Empty) {
                return result;
            }
            try {
                var parsed = JsonConvert.DeserializeObject<T> (json);

                result.Content = parsed;
            }
            catch (JsonException) {
                result.Content = null;
                return result;
            }

            return result;
        }

        public async Task<IKeyValidationStatus> ValidateKeyAsync (string key, AccessLevel requiredLevel) {
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

        private static int ParseErrorCode (string json) {
            var parsed = JsonConvert.DeserializeObject<ResponseError> (json);

            return parsed is null || parsed.Error is null ? -1 : parsed.Error.Code;
        }
    }
}

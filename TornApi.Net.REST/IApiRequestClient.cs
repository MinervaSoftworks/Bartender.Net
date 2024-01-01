using TornApi.Net.Models.Key;

namespace TornApi.Net.REST {
    public interface IApiRequestClient {
        Task<ApiResponse<T>> GetAsync<T> (RequestConfiguration config, AccessLevel accessLevel) where T : class;
        Task<KeyValidationStatus> ValidateKeyAsync (string key, AccessLevel requiredLevel);
    }
}
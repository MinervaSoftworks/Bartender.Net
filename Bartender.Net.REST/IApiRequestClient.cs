using Bartender.Net.Framework.Selection;

namespace TornApi.Net.REST {
    public interface IApiRequestClient {
        Task<IApiResponse<T>?> GetAsync<T> (RequestConfiguration config, AccessLevel accessLevel) where T : class;
        Task<IKeyValidationStatus> ValidateKeyAsync (string key, AccessLevel requiredLevel);
    }
}
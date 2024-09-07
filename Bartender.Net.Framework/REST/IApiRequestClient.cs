using Bartender.Net.Framework.Selection;

namespace Bartender.Net.Framework.REST;

public interface IApiRequestClient {
    Task<IApiResponse<T>?> GetAsync<T> (IRequestConfiguration config) where T : class;
    Task<IKeyValidationStatus> ValidateKeyAsync (string key, AccessLevel requiredLevel);
}
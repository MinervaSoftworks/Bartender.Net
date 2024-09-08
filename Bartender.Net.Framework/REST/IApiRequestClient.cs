using Bartender.Net.Framework.Section;

namespace Bartender.Net.Framework.REST;

public interface IApiRequestClient {
    Task<IApiResponse<T>> FetchSelectionAsync<T> (IRequestConfiguration requestConfiguration);
    Task<IApiResponse<IEnumerable<object>>> FetchMultipleSelectionsAsync (IRequestConfiguration requestConfiguration);
    Task<IKeyValidationStatus> ValidateKeyForSelectionAsync (string key, Selection selection);
}
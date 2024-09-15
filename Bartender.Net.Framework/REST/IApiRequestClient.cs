using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Framework.REST;

public interface IApiRequestClient {
    Task<IApiResponse> FetchAsync (IRequestConfiguration requestConfiguration);
    Task<ISingleSelectionApiResponse<T>> FetchSingleSelectionAsync<T> (IRequestConfiguration requestConfiguration) where T : IBartenderEntity;
    Task<IKeyValidationStatus> ValidateKeyForSelectionAsync (string key, Selection selection);
}
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Framework.REST;

public interface IApiRequestClient {
    Task<IApiResponse> FetchAsync (IRequestConfiguration requestConfiguration);
    Task<IKeyValidationStatus> ValidateKeyForSelectionAsync (string key, Selection selection);
}
using Bartender.Net.Framework.Section;

namespace Bartender.Net.Framework.REST;

public interface IApiRequestClient {
    Task<IKeyValidationStatus> ValidateKeyForSelectionAsync (string key, Selection selection);
}
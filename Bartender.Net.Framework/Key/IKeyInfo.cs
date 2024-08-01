using Bartender.Net.Framework.Selection;

namespace Bartender.Net.Framework.Key;

public interface IKeyInfo {
    AccessLevel AccessLevel { get; }
    string AccessLevelString { get; }
    int ID { get; }
}
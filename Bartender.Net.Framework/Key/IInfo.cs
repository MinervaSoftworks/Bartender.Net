using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Framework.Key;

public interface IKeyInfo {
    AccessLevel AccessLevel { get; }
    string AccessLevelString { get; }
    int ID { get; }
    IKeySelections Selections { get; }
}
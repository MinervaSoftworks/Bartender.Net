using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Framework.Key;

public interface IKeyInfo {
    AccessLevel AccessLevel { get; set; }
    string AccessLevelString { get; set; }
    int ID { get; set; }
    IKeySelections Selections { get; set; }
}
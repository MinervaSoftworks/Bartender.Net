namespace Bartender.Net.Framework.Key;

public interface IKeySelections {
    List<string> Company { get; }
    List<string> Faction { get; }
    List<string> Key { get; }
    List<string> Market { get; }
    List<string> Property { get; }
    List<string> Torn { get; }
    List<string> User { get; }

    bool HasSelectionAccess (string selection);
}
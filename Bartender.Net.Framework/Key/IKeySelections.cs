namespace Bartender.Net.Framework.Key;

public interface IKeySelections {
    IEnumerable<string> Company { get; }
    IEnumerable<string> Faction { get; }
    IEnumerable<string> Key { get; }
    IEnumerable<string> Market { get; }
    IEnumerable<string> Property { get; }
    IEnumerable<string> Torn { get; }
    IEnumerable<string> User { get; }
}
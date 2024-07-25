namespace Bartender.Net.Framework.Key;

public interface IKeySelections {
    IEnumerable<string> Company { get; set; }
    IEnumerable<string> Faction { get; set; }
    IEnumerable<string> Key { get; set; }
    IEnumerable<string> Market { get; set; }
    IEnumerable<string> Property { get; set; }
    IEnumerable<string> Torn { get; set; }
    IEnumerable<string> User { get; set; }
}
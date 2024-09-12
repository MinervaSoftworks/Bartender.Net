using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Key;

public class KeySelections : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company")]
    public required List<string> Company { get; set; }

    [JsonProperty ("faction")]
    public required List<string> Faction { get; set; }

    [JsonProperty ("Key")]
    public required List<string> Key { get; set; }

    [JsonProperty ("Market")]
    public required List<string> Market { get; set; }

    [JsonProperty ("Property")]
    public required List<string> Property { get; set; }

    [JsonProperty ("Torn")]
    public required List<string> Torn { get; set; }

    [JsonProperty ("User")]
    public required List<string> User { get; set; }

    public bool HasSelectionAccess (string selection) => Company.Contains (selection)
                                                         || Faction.Contains (selection)
                                                         || Key.Contains (selection)
                                                         || Market.Contains (selection)
                                                         || Property.Contains (selection)
                                                         || Torn.Contains (selection)
                                                         || User.Contains (selection);
}

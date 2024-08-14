using Newtonsoft.Json;

namespace Bartender.Net.Key;

public class KeySelections {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company")]
    public List<string> Company { get; set; }

    [JsonProperty ("faction")]
    public List<string> Faction { get; set; }

    [JsonProperty ("Key")]
    public List<string> Key { get; set; }

    [JsonProperty ("Market")]
    public List<string> Market { get; set; }

    [JsonProperty ("Property")]
    public List<string> Property { get; set; }

    [JsonProperty ("Torn")]
    public List<string> Torn { get; set; }

    [JsonProperty ("User")]
    public List<string> User { get; set; }

    public bool HasSelectionAccess (string selection) => Company.Contains (selection)
                                                         || Faction.Contains (selection)
                                                         || Key.Contains (selection)
                                                         || Market.Contains (selection)
                                                         || Property.Contains (selection)
                                                         || Torn.Contains (selection)
                                                         || User.Contains (selection);
}

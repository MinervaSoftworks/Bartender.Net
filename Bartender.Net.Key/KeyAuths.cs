using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Key;

public class KeyAuths : BartenderEntity {
    [JsonProperty ("company")]
    public virtual required List<string> Company { get; set; }

    [JsonProperty ("faction")]
    public virtual required List<string> Faction { get; set; }

    [JsonProperty ("key")]
    public virtual required List<string> Key { get; set; }

    [JsonProperty ("market")]
    public virtual required List<string> Market { get; set; }

    [JsonProperty ("property")]
    public virtual required List<string> Property { get; set; }

    [JsonProperty ("torn")]
    public virtual required List<string> Torn { get; set; }

    [JsonProperty ("user")]
    public virtual required List<string> User { get; set; }

    public bool HasSelectionAccess (string selection) => Company.Contains (selection)
                                                         || Faction.Contains (selection)
                                                         || Key.Contains (selection)
                                                         || Market.Contains (selection)
                                                         || Property.Contains (selection)
                                                         || Torn.Contains (selection)
                                                         || User.Contains (selection);
}

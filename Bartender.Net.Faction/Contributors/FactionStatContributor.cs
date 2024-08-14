using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributor {
    [JsonProperty ("contributed")]
    public int Contributed { get; set; }

    [JsonProperty ("in_faction")]
    public int InFaction { get; set; }
}

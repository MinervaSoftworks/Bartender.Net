using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributor {
    [JsonProperty ("contributed")]
    public required int Contributed { get; set; }

    [JsonProperty ("in_faction")]
    public required int InFaction { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWars {
    [JsonProperty ("rankedwars")]
    public IDictionary<string, IRankedWarEntry> RankedWars { get; set; }
}

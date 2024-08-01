using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWars : IRankedWars {
    [JsonProperty ("rankedwars")]
    public IDictionary<string, IRankedWarEntry> Wars { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarsRoot {
    [JsonProperty ("rankedwars")]
    public required Dictionary<string, RankedWarEntry> Wars { get; set; }
}

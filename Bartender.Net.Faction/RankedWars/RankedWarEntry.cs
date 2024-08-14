using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarEntry {
    [JsonIgnore]
    public  int ID { get; set; }

    [JsonProperty ("war")]
    public RankedWar Rankedwar { get; set; }

    [JsonProperty ("factions")]
    public required Dictionary<string, RankedWarFaction> Factions { get; set; }
}

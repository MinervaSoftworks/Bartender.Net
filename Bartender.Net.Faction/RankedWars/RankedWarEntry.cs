using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarEntry : IRankedWarEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("war")]
    public IRankedWar Rankedwar { get; set; }

    [JsonProperty ("factions")]
    public IDictionary<string, IRankedWarFaction> Factions { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarEntry : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("war")]
    public required RankedWar Rankedwar { get; set; }

    [JsonProperty ("factions")]
    public required Dictionary<string, RankedWarFaction> Factions { get; set; }
}

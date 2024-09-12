using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class RankedWar : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("factions")]
    public required Dictionary<string, RankedWarFaction> Factions { get; set; }

    [JsonProperty ("war")]
    public War War { get; set; }
}

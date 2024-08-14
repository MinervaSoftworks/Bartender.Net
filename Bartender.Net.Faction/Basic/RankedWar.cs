using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class RankedWar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("factions")]
    public Dictionary<string, RankedWarFaction> Factions { get; set; }

    [JsonProperty ("war")]
    public War War { get; set; }
}

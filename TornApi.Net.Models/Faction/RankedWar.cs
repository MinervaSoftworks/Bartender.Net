using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class RankedWar {
    [JsonIgnore]
    public int ID { get; set; }

    public int RankedWarID { get; set; }

    [JsonProperty ("factions")]
    public IDictionary<string, RankedWarFaction> Factions { get; set; }

    [JsonProperty ("war")]
    public War War { get; set; }
}

using Bartender.Net.Framework.Faction.Basic;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class RankedWar : IRankedWar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("factions")]
    public IDictionary<string, IRankedWarFaction> Factions { get; set; }

    [JsonProperty ("war")]
    public IWar War { get; set; }
}

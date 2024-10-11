using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class RankedWar : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("factions")]
    public required Dictionary<string, RankedWarFaction> Factions { get; set; }

    [JsonProperty ("war")]
    public virtual required War War { get; set; }
}

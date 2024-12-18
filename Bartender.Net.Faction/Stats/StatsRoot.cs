using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Stats;

public class StatsRoot : BartenderEntity {
    [JsonProperty ("stats")]
    public virtual required StatsEntry Stats { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Stats;

public class StatsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("stats")]
    public virtual required StatsEntry Stats { get; set; }
}

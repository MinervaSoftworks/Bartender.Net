using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class PersonalStatsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("personalstats")]
    public virtual required PersonalStatsEntry PersonalStats { get; set; }
}
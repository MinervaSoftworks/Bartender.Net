using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class PersonalStatsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("personalstats")]
    public required PersonalStats PersonalStats { get; set; }
}
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class PersonalStatsRoot {
    [JsonProperty ("personalstats")]
    public required PersonalStats PersonalStats { get; set; }
}
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class UserPersonalStats {
    [JsonProperty ("personalstats")]
    public required PersonalStats PersonalStats { get; set; }
}
using Bartender.Net.Framework.User.PersonalStats;
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class UserPersonalStats : IUserPersonalStats {
    [JsonProperty ("personalstats")]
    public required IPersonalStats PersonalStats { get; set; }
}
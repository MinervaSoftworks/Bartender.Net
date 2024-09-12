using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Cooldowns;

public class UserCooldowns : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("drug")]
    public required int Drug { get; set; }

    [JsonProperty ("medical")]
    public required int Medical { get; set; }

    [JsonProperty ("booster")]
    public required int Booster { get; set; }
}

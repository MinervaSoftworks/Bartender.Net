using Newtonsoft.Json;

namespace Bartender.Net.User.UserCooldowns;

public class CooldownCollection {
    [JsonProperty ("drug")]
    public required int Drug { get; set; }

    [JsonProperty ("medical")]
    public required int Medical { get; set; }

    [JsonProperty ("booster")]
    public required int Booster { get; set; }
}

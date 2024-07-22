using Newtonsoft.Json;

namespace Bartender.Net.User.UserCooldowns;

public class UserCooldowns {
    [JsonProperty ("cooldowns")]
    public required CooldownCollection Cooldowns { get; set; }
}

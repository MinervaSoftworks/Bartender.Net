using Newtonsoft.Json;

namespace Bartender.Net.User.Cooldowns;

public class UserCooldownsRoot {
    [JsonProperty ("cooldowns")]
    public required UserCooldowns Cooldowns { get; set; }
}

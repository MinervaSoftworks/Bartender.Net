using Newtonsoft.Json;

namespace Bartender.Net.User.UserCooldowns;

public class UserCooldownsCollection {
    [JsonProperty ("cooldowns")]
    public required UserCooldowns Cooldowns { get; set; }
}

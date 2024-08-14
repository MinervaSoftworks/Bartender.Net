using Newtonsoft.Json;

namespace Bartender.Net.User.UserCooldowns;

public class UserCooldownsCollection {
    [JsonProperty ("cooldowns")]
    public UserCooldowns Cooldowns { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Cooldowns;

public class CooldownsRoot {
    [JsonProperty ("cooldowns")]
    public required UserCooldowns Cooldowns { get; set; }
}

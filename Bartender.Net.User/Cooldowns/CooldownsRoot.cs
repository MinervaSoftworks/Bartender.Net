using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Cooldowns;

public class CooldownsRoot : BartenderEntity {
    [JsonProperty ("cooldowns")]
    public virtual required UserCooldowns Cooldowns { get; set; }
}

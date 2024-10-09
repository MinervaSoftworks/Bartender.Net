using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Cooldowns;

public class CooldownsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cooldowns")]
    public virtual required UserCooldowns Cooldowns { get; set; }
}

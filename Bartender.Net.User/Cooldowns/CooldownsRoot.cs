using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Cooldowns;

public class CooldownsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("cooldowns")]
    public virtual required UserCooldowns Cooldowns { get; set; }
}

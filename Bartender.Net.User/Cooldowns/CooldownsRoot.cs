using Newtonsoft.Json;

namespace Bartender.Net.User.Cooldowns;

public class CooldownsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cooldowns")]
    public required UserCooldowns Cooldowns { get; set; }
}

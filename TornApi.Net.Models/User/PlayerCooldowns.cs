using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class PlayerCooldowns {
    [JsonProperty("cooldowns")]
    public Cooldowns Cooldowns { get; set; }
}

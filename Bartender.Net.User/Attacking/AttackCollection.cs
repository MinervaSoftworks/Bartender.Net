using Newtonsoft.Json;

namespace Bartender.Net.User.Attacking;

public class AttackCollection {
    [JsonProperty("attacks")]
    public required IDictionary<string, Attack> Attacks { get; set; }
}

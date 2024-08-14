using Newtonsoft.Json;

namespace Bartender.Net.User.Attacking;

public class AttackCollection {
    [JsonProperty ("attacks")]
    public required Dictionary<string, Attack> Attacks { get; set; }
}

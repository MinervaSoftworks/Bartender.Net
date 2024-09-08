using Newtonsoft.Json;

namespace Bartender.Net.User.Attacks;

public class UserAttackRoot {
    [JsonProperty ("attacks")]
    public required Dictionary<string, UserAttack> Attacks { get; set; }
}

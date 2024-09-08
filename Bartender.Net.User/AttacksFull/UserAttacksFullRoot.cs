using Newtonsoft.Json;

namespace Bartender.Net.User.AttacksFull;

public class UserAttacksFullRoot {
    [JsonProperty ("attacks")]
    public required Dictionary<string, UserAttackStub> Attacks { get; set; }
}
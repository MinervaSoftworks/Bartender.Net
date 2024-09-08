using Newtonsoft.Json;

namespace Bartender.Net.User.AttacksFull;

public class AttacksFullRoot {
    [JsonProperty ("attacks")]
    public required Dictionary<string, AttackStub> Attacks { get; set; }
}
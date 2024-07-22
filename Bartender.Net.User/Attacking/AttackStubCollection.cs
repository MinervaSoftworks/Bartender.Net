using Newtonsoft.Json;

namespace Bartender.Net.User.Attacking;

public class AttackStubCollection {
    [JsonProperty("attacks")]
    public required IDictionary<string, AttackStub> Attacks { get; set; }
}
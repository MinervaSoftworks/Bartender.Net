using Newtonsoft.Json;

namespace Bartender.Net.User.Attacking;

public class AttackStubCollection {
    [JsonProperty ("attacks")]
    public Dictionary<string, AttackStub> Attacks { get; set; }
}
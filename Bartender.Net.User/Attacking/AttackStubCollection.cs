using Bartender.Net.Framework.User.Attacking;
using Newtonsoft.Json;

namespace Bartender.Net.User.Attacking;

public class AttackStubCollection : IAttackStubCollection {
    [JsonProperty ("attacks")]
    public IDictionary<string, IAttackStub> Attacks { get; set; }
}
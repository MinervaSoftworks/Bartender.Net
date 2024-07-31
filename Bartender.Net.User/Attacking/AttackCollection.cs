using Bartender.Net.Framework.User.Attacking;
using Newtonsoft.Json;

namespace Bartender.Net.User.Attacking;

public class AttackCollection : IAttackCollection {
    [JsonProperty ("attacks")]
    public IDictionary<string, IAttack> Attacks { get; set; }
}

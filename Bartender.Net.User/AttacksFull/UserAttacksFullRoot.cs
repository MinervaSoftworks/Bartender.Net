using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.AttacksFull;

public class UserAttacksFullRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public required Dictionary<string, UserAttackStub> Attacks { get; set; }
}
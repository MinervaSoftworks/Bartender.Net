using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Attacks;

public class UserAttacksRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("attacks")]
    public required Dictionary<string, UserAttack> Attacks { get; set; }
}

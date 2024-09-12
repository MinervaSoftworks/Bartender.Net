using Newtonsoft.Json;

namespace Bartender.Net.User.Attacks;

public class UserAttacksRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public required Dictionary<string, UserAttack> Attacks { get; set; }
}

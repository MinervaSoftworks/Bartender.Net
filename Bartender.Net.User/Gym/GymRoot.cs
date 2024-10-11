using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Gym;

public class GymRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("active_gym")]
    public required int ActiveGym { get; set; }
}

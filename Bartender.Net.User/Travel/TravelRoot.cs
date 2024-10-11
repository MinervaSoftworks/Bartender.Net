using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("travel")]
    public virtual required TravelEntry Travel { get; set; }
}

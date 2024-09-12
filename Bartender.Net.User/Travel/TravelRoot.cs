using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("travel")]
    public required TravelEntry Travel { get; set; }
}

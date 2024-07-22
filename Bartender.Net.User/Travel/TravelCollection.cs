using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelCollection {
    [JsonProperty ("travel")]
    public required TravelEntry Travel { get; set; }
}

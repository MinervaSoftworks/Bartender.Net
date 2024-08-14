using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelRoot {
    [JsonProperty ("travel")]
    public required TravelEntry Travel { get; set; }
}

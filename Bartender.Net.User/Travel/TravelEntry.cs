using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelEntry : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("destination")]
    public required string Destination { get; set; }

    [JsonProperty ("method")]
    public required string Method { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("departed")]
    public required int Departed { get; set; }

    [JsonProperty ("time_left")]
    public required int TimeLeft { get; set; }
}

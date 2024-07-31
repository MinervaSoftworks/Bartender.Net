using Bartender.Net.Framework.User.Travel;
using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelEntry : ITravelEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("destination")]
    public string Destination { get; set; }

    [JsonProperty ("method")]
    public string Method { get; set; }

    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty ("departed")]
    public int Departed { get; set; }

    [JsonProperty ("time_left")]
    public int TimeLeft { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class ChainBar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cooldown")]
    public required int Cooldown { get; set; }

    [JsonProperty ("currnet")]
    public required int Current { get; set; }

    [JsonProperty ("maximum")]
    public required int Maximum { get; set; }

    [JsonProperty ("modifier")]
    public required float Modifier { get; set; }

    [JsonProperty ("timeout")]
    public required int Timeout { get; set; }
}

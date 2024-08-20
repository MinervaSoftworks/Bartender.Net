using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("end")]
    public required int End { get; set; }

    [JsonProperty ("start")]
    public required int Start { get; set; }

    [JsonProperty ("target")]
    public required int Target { get; set; }

    [JsonProperty ("winner")]
    public required int Winner { get; set; }
}

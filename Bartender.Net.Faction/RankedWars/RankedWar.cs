using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWar : IRankedWar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("end")]
    public int End { get; set; }

    [JsonProperty ("start")]
    public int Start { get; set; }

    [JsonProperty ("target")]
    public int Target { get; set; }

    [JsonProperty ("winner")]
    public int Winner { get; set; }
}

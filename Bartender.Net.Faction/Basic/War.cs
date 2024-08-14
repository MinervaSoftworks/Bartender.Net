using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class War {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("end")]
    public long End { get; set; }

    [JsonProperty ("start")]
    public long Start { get; set; }

    [JsonProperty ("target")]
    public required int Target { get; set; }

    [JsonProperty ("winner")]
    public decimal Winner { get; set; }
}

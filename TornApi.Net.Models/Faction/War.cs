using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class War {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("end")]
    public long End { get; set; }

    [JsonProperty ("start")]
    public long Start { get; set; }

    [JsonProperty ("target")]
    public int Target { get; set; }

    [JsonProperty ("winner")]
    public decimal Winner { get; set; }
}

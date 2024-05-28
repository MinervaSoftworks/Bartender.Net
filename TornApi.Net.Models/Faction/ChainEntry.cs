using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class ChainEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("chain")]
    public int ChainID { get; set; }

    [JsonProperty ("respect")]
    public string Respect { get; set; }

    [JsonProperty ("start")]
    public int Start { get; set; }

    [JsonProperty ("end")]
    public int End { get; set; }
}

using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class CurrentChain {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("current")]
    public int Current { get; set; }

    [JsonProperty ("max")]
    public int Max { get; set; }

    [JsonProperty ("timeout")]
    public int Timeout { get; set; }

    [JsonProperty ("modifier")]
    public int Modifier { get; set; }

    [JsonProperty ("cooldown")]
    public int Cooldown { get; set; }

    [JsonProperty ("start")]
    public int Start { get; set; }

    [JsonProperty ("end")]
    public int End { get; set; }
}

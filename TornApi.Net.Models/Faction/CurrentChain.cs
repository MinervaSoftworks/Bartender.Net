using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class CurrentChain {
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

public class ChainEntry {
    [JsonProperty ("chain")]
    public int ChainID { get; set; }

    [JsonProperty ("respect")]
    public string Respect { get; set; }

    [JsonProperty ("start")]
    public int Start { get; set; }

    [JsonProperty ("end")]
    public int End { get; set; }
}

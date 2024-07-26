namespace TornApi.Net.Models.Faction;

using Newtonsoft.Json;

public class FactionChainOverview {
    [JsonProperty ("chainreport")]
    public ChainReport Chainreport { get; set; }
}

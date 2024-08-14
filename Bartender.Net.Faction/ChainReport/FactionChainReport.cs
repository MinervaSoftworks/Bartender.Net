using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class FactionChainReport {
    [JsonProperty ("chainreport")]
    public ChainReport Chainreport { get; set; }
}
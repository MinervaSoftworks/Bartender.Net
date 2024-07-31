using Bartender.Net.Framework.Faction.ChainReport;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class FactionChainReport : IFactionChainReport {
    [JsonProperty ("chainreport")]
    public IChainReport Chainreport { get; set; }
}
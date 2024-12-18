using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class ChainReportRoot : BartenderEntity {
    [JsonProperty ("chainreport")]
    public required FactionChainReport ChainReport { get; set; }
}
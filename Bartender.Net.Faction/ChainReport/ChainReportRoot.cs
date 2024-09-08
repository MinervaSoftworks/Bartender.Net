using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class ChainReportRoot {
    [JsonProperty ("chainreport")]
    public Report Chainreport { get; set; }
}
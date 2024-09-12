using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class ChainReportRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("chainreport")]
    public Report Chainreport { get; set; }
}
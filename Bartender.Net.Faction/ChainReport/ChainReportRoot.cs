using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class ChainReportRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("chainreport")]
    public required Report ChainReport { get; set; }
}
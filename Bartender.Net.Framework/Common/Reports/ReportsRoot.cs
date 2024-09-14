using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class ReportsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("reports")]
    public required List<Report> Reports { get; set; }
}

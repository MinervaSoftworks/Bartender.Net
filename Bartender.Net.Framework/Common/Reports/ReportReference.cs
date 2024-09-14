using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class ReportReference : IBartenderEntity {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("joined")]
    public required string Joined { get; set; }

    [JsonProperty ("left")]
    public required string Left { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }
}

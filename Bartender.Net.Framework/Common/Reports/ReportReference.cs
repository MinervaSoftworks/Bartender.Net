using Newtonsoft.Json;

namespace Bartender.Net.Common.Reports;

public class ReportReference {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("joined")]
    public required string Joined { get; set; }

    [JsonProperty ("left")]
    public required string Left { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }
}

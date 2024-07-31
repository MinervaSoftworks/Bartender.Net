using Bartender.Net.Framework.User.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class ReportReference : IReportReference {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("joined")]
    public string Joined { get; set; }

    [JsonProperty ("left")]
    public string Left { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }
}

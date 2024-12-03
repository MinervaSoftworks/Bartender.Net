using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class ReportReference : BartenderEntity {
    [JsonProperty ("ID")]
    public override int ID { get; set; }

    [JsonProperty ("joined")]
    public required string Joined { get; set; }

    [JsonProperty ("left")]
    public required string Left { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    public ReportData CompanyReport { get; set; } = default!;
    public int CompanyReportID { get; set; } = default!;

    public ReportData FactionReport { get; set; } = default!;
    public int FactionReportID { get; set; } = default!;
}

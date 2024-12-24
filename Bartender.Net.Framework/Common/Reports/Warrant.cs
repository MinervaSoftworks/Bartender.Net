using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class Warrant : BartenderEntity {
    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("user_id")]
    public required int UserID { get; set; }

    [JsonProperty ("warrant")]
    public required int Amount { get; set; }

    public virtual ReportData OtherReport { get; set; } = default!;
    public int OtherReportID { get; set; } = default!;

    public virtual ReportData TopReport { get; set; } = default!;
    public int TopReportID { get; set; } = default!;
}

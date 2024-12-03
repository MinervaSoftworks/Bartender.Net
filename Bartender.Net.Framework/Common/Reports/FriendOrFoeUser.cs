using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class FriendOrFoeUser : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    public virtual ReportData FriendReportData { get; set; } = default!;

    public int FriendReportDataID { get; set; }

    public virtual ReportData FoeReportData { get; set; } = default!;

    public int FoeReportDataID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("user_id")]
    public required int UserID { get; set; }
}


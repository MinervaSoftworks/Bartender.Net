using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class Report : IReport {
    [JsonProperty("id")]
    public required int ID { get; set; }

    [JsonProperty("report")]
    public required IReportData Data { get; set; }

    [JsonProperty("target")]
    public required int Target { get; set; }

    [JsonProperty("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty("type")]
    public required string Type { get; set; }

    [JsonIgnore]
    public required ReportType ReportType {
        get => Type.ToReportType ();
        set => Type = value.ToReportTypeString ();
    }

    [JsonProperty("user_id")]
    public required int UserID { get; set; }
}

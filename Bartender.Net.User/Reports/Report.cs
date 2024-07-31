using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class Report : IReport {
    [JsonProperty ("id")]
    public int ID { get; set; }

    [JsonProperty ("report")]
    public IReportData Data { get; set; }

    [JsonProperty ("target")]
    public int Target { get; set; }

    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonIgnore]
    public ReportType ReportType {
        get => Type.ToReportType ();
        set => Type = value.ToReportTypeString ();
    }

    [JsonProperty ("user_id")]
    public int UserID { get; set; }
}

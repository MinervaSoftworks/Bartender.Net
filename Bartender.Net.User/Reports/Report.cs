using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class Report {
    [JsonProperty("id")]
    public required int ID { get; set; }

    [JsonProperty("report")]
    public required ReportData Data { get; set; }

    [JsonProperty("target")]
    public required int Target { get; set; }

    [JsonProperty("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty("type")]
    public required string @Type {
        get => ReportTypeToType (ReportType);
        set => ReportType = TypeToReportType (value); 
    }

    [JsonIgnore]
    public required ReportType ReportType { get; set; }

    [JsonProperty("user_id")]
    public required int UserID { get; set; }

    public required static ReportType TypeToReportType (string reportType) => reportType switch {
        "anonymousbounties" => ReportType.AnonymousBounties,
        "friendorfoe" => ReportType.FriendOrFoe,
        "investment" => ReportType.Investment,
        "money" => ReportType.Money,
        "mostwanted" => ReportType.MostWanted,
        "references" => ReportType.References,
        "stats" => ReportType.Stats,
        "truelevel" => ReportType.TrueLevel,
        _ => throw new ArgumentException ("Invalid report type"),
    };

    public required static string ReportTypeToType (ReportType reportType) => reportType switch {
        ReportType.AnonymousBounties => "anonymousbounties",
        ReportType.FriendOrFoe => "friendorfoe",
        ReportType.Investment => "investment",
        ReportType.Money => "money",
        ReportType.MostWanted => "mostwanted",
        ReportType.References => "references",
        ReportType.Stats => "stats",
        ReportType.TrueLevel => "truelevel",
        _ => throw new ArgumentException ("Invalid ReportType value"),
    };
}

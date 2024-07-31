using Bartender.Net.Framework.Common.Reports;

namespace Bartender.Net.Extensions.User;

public static class ReportTypeExtensions {
    public static string ToReportTypeString (this ReportType reportType) => reportType switch {
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
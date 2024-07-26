namespace Bartender.Net.Framework.User.Reports;

public interface IReport : IBartenderEntity {
    IReportData Data { get; }
    string ReportTypeString { get; }
    ReportType ReportType { get; }
    int Target { get; }
    int Timestamp { get; }
    string Type { get; }
    int UserID { get; }
}
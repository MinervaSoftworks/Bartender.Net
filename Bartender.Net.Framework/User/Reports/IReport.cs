namespace Bartender.Net.Framework.User.Reports;

public interface IReport : IBartenderEntity {
    IReportData Data { get; set; }
    string ReportTypeString { get; set; }
    ReportType ReportType { get; set; }
    int Target { get; set; }
    int Timestamp { get; set; }
    string Type { get; set; }
    int UserID { get; set; }
}
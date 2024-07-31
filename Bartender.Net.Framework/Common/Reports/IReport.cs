namespace Bartender.Net.Framework.Common.Reports;

public interface IReport : IBartenderEntity {
    IReportData Data { get; }
    ReportType ReportType { get; }
    int Target { get; }
    int Timestamp { get; }
    string Type { get; }
    int UserID { get; }
}
namespace Bartender.Net.Framework.Common.Reports;

public interface IReportReference : IBartenderEntity {
    string Joined { get; }
    string Left { get; }
    string Name { get; }
}
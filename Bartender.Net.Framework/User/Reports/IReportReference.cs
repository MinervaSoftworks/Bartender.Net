namespace Bartender.Net.Framework.User.Reports;

public interface IReportReference : IBartenderEntity {
    string Joined { get; }
    string Left { get; }
    string Name { get; }
}
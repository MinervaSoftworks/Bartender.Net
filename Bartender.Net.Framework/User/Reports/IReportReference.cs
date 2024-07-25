namespace Bartender.Net.Framework.User.Reports;

public interface IReportReference : IBartenderEntity {
    string Joined { get; set; }
    string Left { get; set; }
    string Name { get; set; }
}
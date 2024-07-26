namespace Bartender.Net.Framework.User.Reports;

public interface IWarrant : IBartenderEntity {
    int Amount { get; }
    string Name { get; }
    int UserID { get; }
}
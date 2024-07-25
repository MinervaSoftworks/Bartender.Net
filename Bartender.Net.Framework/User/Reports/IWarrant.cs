namespace Bartender.Net.Framework.User.Reports;

public interface IWarrant : IBartenderEntity {
    int Amount { get; set; }
    string Name { get; set; }
    int UserID { get; set; }
}
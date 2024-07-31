namespace Bartender.Net.Framework.Common.Reports;

public interface IWarrant : IBartenderEntity {
    int Amount { get; }
    string Name { get; }
    int UserID { get; }
}
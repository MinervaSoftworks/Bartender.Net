namespace Bartender.Net.Framework.User.Stocks;

public interface IStockBonus : IBartenderEntity {
    int Frequency { get; }
    int Increment { get; }
    int Progress { get; }
    int Ready { get; }
}
namespace Bartender.Net.Framework.User.Stocks;

public interface IStockTransaction : IBartenderEntity {
    double BoughtPrice { get; }
    int Shares { get; }
    long TimeBought { get; }
}
namespace Bartender.Net.Framework.User.Stocks;

public interface IStockTransaction : IBartenderEntity {
    double BoughtPrice { get; set; }
    int Shares { get; set; }
    long TimeBought { get; set; }
}
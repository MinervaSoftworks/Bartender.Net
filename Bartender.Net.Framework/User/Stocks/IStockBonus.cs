namespace Bartender.Net.Framework.User.Stocks;

public interface IStockBonus : IBartenderEntity {
    int Frequency { get; set; }
    int Increment { get; set; }
    int Progress { get; set; }
    int Ready { get; set; }
}
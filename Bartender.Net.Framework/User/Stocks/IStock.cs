namespace Bartender.Net.Framework.User.Stocks;

public interface IStock : IBartenderEntity {
    IStockBonus Benefit { get; set; }
    IStockBonus Dividend { get; set; }
    int StockId { get; set; }
    int TotalShares { get; set; }
    Dictionary<string, IStockTransaction> Transactions { get; set; }
}
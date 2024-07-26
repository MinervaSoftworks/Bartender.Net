namespace Bartender.Net.Framework.User.Stocks;

public interface IStock : IBartenderEntity {
    IStockBonus Benefit { get; }
    IStockBonus Dividend { get; }
    int StockId { get; }
    int TotalShares { get; }
    Dictionary<string, IStockTransaction> Transactions { get; }
}
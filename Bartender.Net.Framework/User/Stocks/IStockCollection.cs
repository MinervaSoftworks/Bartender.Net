namespace Bartender.Net.Framework.User.Stocks;

public interface IStockCollection {
    IDictionary<string, IStock> Stocks { get; }
}
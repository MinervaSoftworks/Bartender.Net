namespace Bartender.Net.Framework.User.Stocks;

public interface IStockRoot {
    IDictionary<string, IStock> Stocks { get; }
}
namespace Bartender.Net.Framework.Company.Stock;

public interface ICompanyStocks {
    IDictionary<string, ICompanyStock> Stocks { get; set; }
}

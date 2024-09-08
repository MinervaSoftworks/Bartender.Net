namespace Bartender.Net.Company.Stock;

public class StockRoot {
    public required Dictionary<string, CompanyStock> Stocks { get; set; }
}

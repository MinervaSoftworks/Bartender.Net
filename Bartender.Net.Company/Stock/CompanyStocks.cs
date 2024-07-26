using Bartender.Net.Framework.Company.Stock;

namespace Bartender.Net.Company.Stock;

public class CompanyStocks : ICompanyStocks {
    public required IDictionary<string, ICompanyStock> Stocks { get; set; }
}

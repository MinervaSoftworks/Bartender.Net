using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Stock;

public class StockRoot {
    [JsonProperty ("company_stock")]
    public required Dictionary<string, CompanyStock> Stocks { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Stock;

public class StockRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company_stock")]
    public required Dictionary<string, CompanyStock> Stocks { get; set; }
}

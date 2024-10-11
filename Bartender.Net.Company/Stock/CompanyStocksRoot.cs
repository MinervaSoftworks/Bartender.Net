using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Stock;

public class CompanyStocksRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("company_stock")]
    public required Dictionary<string, CompanyStock> Stocks { get; set; }
}

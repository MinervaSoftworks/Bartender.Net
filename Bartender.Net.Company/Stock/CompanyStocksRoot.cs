using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Stock;

public class CompanyStocksRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("company_stock")]
    public Dictionary<string, CompanyStock> Stocks { get; set; } = default!;

    public virtual List<CompanyStock> StocksList {
        get => Stocks.TornDictionaryToList ();
        set => Stocks = value.ToTornDictionary ();
    }
}

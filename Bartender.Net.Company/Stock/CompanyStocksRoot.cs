using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Stock;

public class CompanyStocksRoot : BartenderEntity {
    [JsonProperty ("company_stock")]
    public Dictionary<string, CompanyStock> Stocks {
        get => StocksList.ToTornDictionary ();
        set => StocksList = value.TornDictionaryToList ();
    }

    public virtual List<CompanyStock> StocksList { get; set; } = [];
}

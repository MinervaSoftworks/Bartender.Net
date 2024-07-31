using Bartender.Net.Framework.Company.Stock;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Stock;

public class CompanyStock : ICompanyStock {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public string Name { get; set; }

    [JsonProperty ("cost")]
    public int Cost { get; set; }

    [JsonProperty ("in_stock")]
    public int InStock { get; set; }

    [JsonProperty ("on_order")]
    public int OnOrder { get; set; }

    [JsonProperty ("price")]
    public int Price { get; set; }

    [JsonProperty ("rrp")]
    public int RRP { get; set; }

    [JsonProperty ("sold_amount")]
    public int SoldAmount { get; set; }

    [JsonProperty ("sold_worth")]
    public int SoldWorth { get; set; }
}

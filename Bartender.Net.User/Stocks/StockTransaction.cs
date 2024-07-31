using Bartender.Net.Framework.User.Stocks;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class StockTransaction : IStockTransaction {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("shares")]
    public int Shares { get; set; }

    [JsonProperty ("bought_price")]
    public double BoughtPrice { get; set; }

    [JsonProperty ("time_bought")]
    public long TimeBought { get; set; }
}

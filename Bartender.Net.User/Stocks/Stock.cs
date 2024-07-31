using Bartender.Net.Framework.User.Stocks;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class Stock : IStock {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("benefit")]
    public IStockBonus Benefit { get; set; }

    [JsonProperty ("benefit")]
    public IStockBonus Dividend { get; set; }

    [JsonProperty ("stock_id")]
    public int StockId { get; set; }

    [JsonProperty ("total_shares")]
    public int TotalShares { get; set; }

    [JsonProperty ("transactions")]
    public Dictionary<string, IStockTransaction> Transactions { get; set; }
}

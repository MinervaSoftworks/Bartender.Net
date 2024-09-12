using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class Stock : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("benefit")]
    public required StockBonus Benefit { get; set; }

    [JsonProperty ("benefit")]
    public required StockBonus Dividend { get; set; }

    [JsonProperty ("stock_id")]
    public required int StockId { get; set; }

    [JsonProperty ("total_shares")]
    public required int TotalShares { get; set; }

    [JsonProperty ("transactions")]
    public required Dictionary<string, StockTransaction> Transactions { get; set; }
}

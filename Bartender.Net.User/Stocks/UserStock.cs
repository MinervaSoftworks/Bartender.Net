using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class UserStock : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("benefit")]
    public required UserStockBonus Benefit { get; set; }

    [JsonProperty ("benefit")]
    public required UserStockBonus Dividend { get; set; }

    [JsonProperty ("stock_id")]
    public required int StockId { get; set; }

    [JsonProperty ("total_shares")]
    public required int TotalShares { get; set; }

    [JsonProperty ("transactions")]
    public required Dictionary<string, UserStockTransaction> Transactions { get; set; }
}

using Bartender.Net.Framework;
using Bartender.Net.Framework.User.Stocks;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class Stock : IStock {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("benefit")]
    [JsonConverter (typeof(ConcreteConverter<StockBonus>))]
    public required IStockBonus Benefit { get; set; }

    [JsonProperty ("benefit")]
    [JsonConverter (typeof(ConcreteConverter<StockBonus>))]
    public required IStockBonus Dividend { get; set; }

    [JsonProperty ("stock_id")]
    public required int StockId { get; set; }

    [JsonProperty ("total_shares")]
    public required int TotalShares { get; set; }

    [JsonProperty ("transactions")]
    [JsonConverter (typeof(ConcreteConverter<Dictionary<string, StockTransaction>>))]
    public required Dictionary<string, IStockTransaction> Transactions { get; set; }
}

using Bartender.Net.Framework.User.Stocks;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class StockBonus : IStockBonus {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("ready")]
    public int Ready { get; set; }

    [JsonProperty ("increment")]
    public int Increment { get; set; }

    [JsonProperty ("progress")]
    public int Progress { get; set; }

    [JsonProperty ("frequency")]
    public int Frequency { get; set; }
}

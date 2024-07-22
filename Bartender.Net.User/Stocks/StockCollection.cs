using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class StockCollection {
    [JsonProperty ("stocks")]
    public required IDictionary<string, Stock> Stocks { get; set; }
}

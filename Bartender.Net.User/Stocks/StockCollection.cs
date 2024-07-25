using Bartender.Net.Framework.User.Stocks;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class StockCollection : IStockCollection {
    [JsonProperty ("stocks")]
    public required IDictionary<string, IStock> Stocks { get; set; }
}

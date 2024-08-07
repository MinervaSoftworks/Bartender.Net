using Bartender.Net.Framework;
using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.Stocks;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class StockRoot : IStockRoot {
    [JsonProperty ("stocks")]
    [JsonConverter (typeof(ConcreteConverter<Dictionary<string, Stock>>))]
    public required IDictionary<string, IStock> Stocks { get; set; }
}

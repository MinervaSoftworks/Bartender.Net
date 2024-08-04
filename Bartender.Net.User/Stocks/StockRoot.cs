using Bartender.Net.Framework;
using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.Stocks;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class StockRoot : IStockRoot, ISelectionRoot {
    [JsonProperty ("stocks")]
    [JsonConverter (typeof(ConcreteConverter<Stock>))]
    public required IDictionary<string, IStock> Stocks { get; set; }

    public AccessLevel AccessLevelRequired => AccessLevel.Minimal;

    public string EndpointString => "stocks";

    public string Name => "Stocks";
}

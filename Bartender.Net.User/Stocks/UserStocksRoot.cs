using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class UserStocksRoot {
    [JsonProperty ("stocks")]
    public required Dictionary<string, Stock> Stocks { get; set; }
}

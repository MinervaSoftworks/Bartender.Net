using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class UserStocksRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("stocks")]
    public required Dictionary<string, Stock> Stocks { get; set; }
}

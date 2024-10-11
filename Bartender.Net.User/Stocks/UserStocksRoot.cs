using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class UserStocksRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("stocks")]
    public required Dictionary<string, UserStock> Stocks { get; set; }
}

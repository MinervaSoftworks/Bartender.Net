using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Money;

public class CityBank : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("amount")]
    public required int Amount { get; set; }

    [JsonProperty ("time_left")]
    public required int TimeLeft { get; set; }
}

using Bartender.Net.Framework.User.Money;
using Newtonsoft.Json;

namespace Bartender.Net.User.Money;

public class CityBank : ICityBank {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("amount")]
    public required int Amount { get; set; }

    [JsonProperty ("time_left")]
    public required int TimeLeft { get; set; }
}

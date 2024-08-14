using Newtonsoft.Json;

namespace Bartender.Net.User.Money;

public class CityBank {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("amount")]
    public int Amount { get; set; }

    [JsonProperty ("time_left")]
    public int TimeLeft { get; set; }
}

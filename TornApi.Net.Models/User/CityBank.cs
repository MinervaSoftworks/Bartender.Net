using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class CityBank {
    [JsonProperty("amount")]
    public int Amount { get; set; }

    [JsonProperty("time_left")]
    public int TimeLeft { get; set; }
}

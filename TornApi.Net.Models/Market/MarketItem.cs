using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class MarketItem {
    [JsonProperty("cost")]
    public int Cost { get; set; }

    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }
}

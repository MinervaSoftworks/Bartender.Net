using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Display {
    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    [JsonProperty("circulation")]
    public int Circulation { get; set; }

    [JsonProperty("market_price")]
    public int MarketPrice { get; set; }

    [JsonProperty("UID")]
    public long? UID { get; set; }
}

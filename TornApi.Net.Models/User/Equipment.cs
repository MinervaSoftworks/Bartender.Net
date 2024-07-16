using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Equipment {
    [JsonProperty("equipped")]
    public int Equiped { get; set; }

    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("market_price")]
    public int MarketPrice { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("UID")]
    public int UID { get; set; }
}

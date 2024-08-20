using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CityShopItem {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("in_stock")]
    public required int InStock { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("price")]
    public required int Price { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CityShopItem {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("in_stock")]
    public int InStock { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("price")]
    public int Price { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }
}

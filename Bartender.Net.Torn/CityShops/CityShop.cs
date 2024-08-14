using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CityShop {
    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("inventory")]
    public required Dictionary<string, CityShopItem> Inventory { get; set; }
}

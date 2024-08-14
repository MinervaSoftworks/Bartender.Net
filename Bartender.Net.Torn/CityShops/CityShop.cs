using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CityShop {
    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("inventory")]
    public Dictionary<string, CityShopItem> Inventory { get; set; }
}

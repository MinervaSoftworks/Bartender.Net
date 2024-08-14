using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CityShopCollection {
    [JsonProperty ("cityshops")]
    public required Dictionary<string, CityShop> CityShops { get; set; }
}
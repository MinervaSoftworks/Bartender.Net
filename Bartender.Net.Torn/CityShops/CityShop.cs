using Bartender.Net.Framework.Torn.CityShops;
using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CityShop : ICityShop {
    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("inventory")]
    public IDictionary<string, ICityShopItem> Inventory { get; set; }
}

using Bartender.Net.Framework.Torn.CityShops;
using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CityShopCollection : ICityShopCollection {
    [JsonProperty ("cityshops")]
    public IDictionary<string, ICityShop> CityShops { get; set; }
}
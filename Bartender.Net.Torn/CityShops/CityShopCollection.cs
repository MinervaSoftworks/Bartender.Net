using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Torn.CityShops;

public class CityShopCollection {
    [JsonProperty ("cityshops")]
    [NotMapped]
    public Dictionary<string, CityShop> CityShops { get; set; } = default!;

    public virtual List<CityShop> CityShopsList {
        get => CityShops.TornDictionaryToList ();
        set => CityShops = value.ToTornDictionary ();
    }
}
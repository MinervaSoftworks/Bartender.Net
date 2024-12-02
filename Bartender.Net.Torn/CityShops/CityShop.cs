using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Torn.CityShops;

public class CityShop {
    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("inventory")]
    [NotMapped]
    public Dictionary<string, CityShopItem> Inventory { get; set; } = default!;

    public virtual List<CityShopItem> InventoryList {
        get => Inventory.TornDictionaryToList ();
        set => Inventory = value.ToTornDictionary ();
    }
}

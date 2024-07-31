namespace Bartender.Net.Framework.Torn.CityShops;

public interface ICityShop {
    string Name { get; set; }
    IDictionary<string, ICityShopItem> Inventory { get; set; }
}

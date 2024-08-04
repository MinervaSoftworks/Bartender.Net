namespace Bartender.Net.Framework.Torn.CityShops;

public interface ICityShop {
    string Name { get; }
    IDictionary<string, ICityShopItem> Inventory { get; }
}

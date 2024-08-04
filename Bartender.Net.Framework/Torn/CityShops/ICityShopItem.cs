namespace Bartender.Net.Framework.Torn.CityShops;

public interface ICityShopItem {
    string Name { get; }
    string Type { get; }
    int Price { get; }
    int InStock { get; }
}

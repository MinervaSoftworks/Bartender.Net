namespace Bartender.Net.Framework.Torn.CityShops;

public interface ICityShopItem {
    string Name { get; set; }
    string Type { get; set; }
    int Price { get; set; }
    int InStock { get; set; }
}

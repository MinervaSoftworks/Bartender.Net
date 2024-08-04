namespace Bartender.Net.Framework.Torn.CityShops;

public interface ICityShopCollection {
    IDictionary<string, ICityShop> CityShops { get; }
}

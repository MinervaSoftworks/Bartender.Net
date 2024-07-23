namespace Bartender.Net.Framework.User.Bazaar;

public interface IBazaarListing : IBartenderEntity {
    int MarketPrice { get; set; }
    string Name { get; set; }
    IUserProfile Owner { get; set; }
    int Price { get; set; }
    int Quantity { get; set; }
    string Type { get; set; }
}
using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.Bazaar;

public interface IBazaarListing : IBartenderEntity {
    int MarketPrice { get; }
    string Name { get; }
    IUserProfile Owner { get; }
    int Price { get; }
    int Quantity { get; }
    string Type { get; }
}
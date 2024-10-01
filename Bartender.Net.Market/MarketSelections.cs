using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Market.Bazaar;
using Bartender.Net.Market.ItemMarket;
using Bartender.Net.Market.PointsMarket;

namespace Bartender.Net.Market;
public class MarketSelections {
    public static readonly Selection Bazaar = new ("bazaar", AccessLevel.Public, typeof (BazaarRoot), typeof (ItemListing));
    public static readonly Selection ItemMarket = new ("itemmarket", AccessLevel.Public, typeof (ItemMarketRoot), typeof (ItemListing));
    public static readonly Selection PointsMarket = new ("pointsmarket", AccessLevel.Public, typeof (PointsMarketRoot), typeof (PointListing));

    public static IEnumerable<Selection> Selections {
        get {
            yield return Bazaar;
            yield return ItemMarket;
            yield return PointsMarket;
        }
    }
}

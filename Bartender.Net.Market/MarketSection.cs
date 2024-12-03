using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Market.Bazaar;
using Bartender.Net.Market.ItemMarket;
using Bartender.Net.Market.PointsMarket;

namespace Bartender.Net.Market;

public class MarketSection : Section {
    private static MarketSection _instance = default!;

    private readonly static object _lock = new ();

    public static MarketSection Instance {
        get {
            if (_instance == null) {
                lock (_lock) {
                    _instance ??= new MarketSection ();
                }
            }

            return _instance;
        }
    }

    public readonly Selection MarketBazaar;
    public readonly Selection MarketItemMarket;
    public readonly Selection MarketPointsMarket;

    public override IEnumerable<Selection> Selections {
        get {
            yield return MarketBazaar;
            yield return MarketItemMarket;
            yield return MarketPointsMarket;
        }
    }

    private MarketSection () : base ("market") {
        MarketBazaar = new (this, "bazaar", AccessLevel.Public, typeof (BazaarRoot), typeof (ItemListing));
        MarketItemMarket = new (this, "itemmarket", AccessLevel.Public, typeof (ItemMarketRoot), typeof (ItemListing));
        MarketPointsMarket = new (this, "pointsmarket", AccessLevel.Public, typeof (PointsMarketRoot), typeof (PointListing));
    }
}

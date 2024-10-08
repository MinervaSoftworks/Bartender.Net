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

    public readonly Selection Bazaar;
    public readonly Selection ItemMarket;
    public readonly Selection PointsMarket;

    public override IEnumerable<Selection> Selections {
        get {
            yield return Bazaar;
            yield return ItemMarket;
            yield return PointsMarket;
        }
    }

    private MarketSection () : base ("market") {
        Bazaar = new (this, "bazaar", AccessLevel.Public, typeof (BazaarRoot), typeof (ItemListing));
        ItemMarket = new (this, "itemmarket", AccessLevel.Public, typeof (ItemMarketRoot), typeof (ItemListing));
        PointsMarket = new (this, "pointsmarket", AccessLevel.Public, typeof (PointsMarketRoot), typeof (PointListing));
    }
}

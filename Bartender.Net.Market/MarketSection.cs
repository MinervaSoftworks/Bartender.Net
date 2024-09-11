using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Market;
public class MarketSection : ISection {
    public string Name => "market";

    public static readonly Selection Bazaar = new ("bazaar", AccessLevel.Public, typeof (object));
    public static readonly Selection ItemMarket = new ("itemmarket", AccessLevel.Public, typeof (object));
    public static readonly Selection PointsMarket = new ("pointsmarket", AccessLevel.Public, typeof (object));

    public IEnumerable<Selection> Selections {
        get {
            yield return Bazaar;
            yield return ItemMarket;
            yield return PointsMarket;
        }
    }
}

using Bartender.Net.Framework;
using Bartender.Net.Market.Bazaar;
using Bartender.Net.Market.ItemMarket;
using Bartender.Net.Market.PointsMarket;

namespace Bartender.Net.Market;

public class MarketOverview : IBartenderEntity {
    public required int ID { get; set; }

    public required BazaarRoot Bazaar { get; set; }

    public required ItemMarketRoot ItemMarket { get; set; }

    public required PointsMarketRoot PointsMarket { get; set; }
}

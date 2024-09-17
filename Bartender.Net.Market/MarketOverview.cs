using Bartender.Net.Market.Bazaar;
using Bartender.Net.Market.ItemMarket;
using Bartender.Net.Market.PointsMarket;

namespace Bartender.Net.Market;

public record MarketOverview (BazaarRoot? Bazaar = null,
                              ItemMarketRoot? ItemMarket = null,
                              PointsMarketRoot? PointsMarket = null);

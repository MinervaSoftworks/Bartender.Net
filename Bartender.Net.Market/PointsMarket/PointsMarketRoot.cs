using Newtonsoft.Json;

namespace Bartender.Net.Market.PointsMarket;

public class PointsMarketRoot {
    [JsonProperty ("pointsmarket")]
    public required Dictionary<string, PointListing> Points { get; set; }
}

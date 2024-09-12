using Newtonsoft.Json;

namespace Bartender.Net.Market.PointsMarket;

public class PointsMarketRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("pointsmarket")]
    public required Dictionary<string, PointListing> Points { get; set; }
}

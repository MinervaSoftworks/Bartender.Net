using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.PointsMarket;

public class PointsMarketRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("pointsmarket")]
    public required Dictionary<string, PointListing> Points { get; set; }
}

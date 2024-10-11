using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.PointsMarket;

public class PointListing : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("total_cost")]
    public required int TotalCost { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.Models.Market;

public class PointListings {
    [JsonProperty ("pointsmarket")]
    public required Dictionary<string, PointListing> Points { get; set; }
}

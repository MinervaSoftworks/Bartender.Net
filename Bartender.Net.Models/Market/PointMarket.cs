using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class PointMarket {
    [JsonProperty ("pointsmarket")]
    public IDictionary<int, Point> Points { get; set; }
}

using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class Point {
    [JsonProperty ("cost")]
    public int Cost { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("total_cost")]
    public int TotalCost { get; set; }
}

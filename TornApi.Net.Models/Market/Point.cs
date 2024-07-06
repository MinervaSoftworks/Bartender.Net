using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class Point {
    [JsonIgnore]
    public int ID { get; set; }
    
    [JsonProperty ("cost")]
    public int Cost { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("total_cost")]
    public int TotalCost { get; set; }
}

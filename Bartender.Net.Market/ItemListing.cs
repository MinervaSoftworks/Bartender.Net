using Newtonsoft.Json;

namespace Bartender.Net.Market;

public class ItemListing {
    [JsonProperty ("cost")]
    public int Cost { get; set; }

    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market;

public class ItemListing : IBartenderEntity {
    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }
}

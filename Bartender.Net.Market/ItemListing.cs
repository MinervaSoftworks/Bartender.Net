using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market;

public class ItemListing : BartenderEntity {
    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("ID")]
    public override int ID { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }
}

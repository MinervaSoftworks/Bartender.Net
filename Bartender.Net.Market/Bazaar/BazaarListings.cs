using Bartender.Net.Market;
using Newtonsoft.Json;

namespace Bartender.Net.Models.Market.Bazaar;

public class BazaarListings {
    [JsonProperty ("bazaar")]
    public required List<ItemListing> Items { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.Bazaar;

public class BazaarRoot {
    [JsonProperty ("bazaar")]
    public required List<ItemListing> Items { get; set; }
}

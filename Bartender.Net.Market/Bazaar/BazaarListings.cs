using Bartender.Net.Framework.Market;
using Bartender.Net.Framework.Market.Bazaar;
using Newtonsoft.Json;

namespace Bartender.Net.Models.Market.Bazaar;

public class BazaarListings : IBazaarListings {
    [JsonProperty ("bazaar")]
    public required IEnumerable<IItemListing> Items { get; set; }
}

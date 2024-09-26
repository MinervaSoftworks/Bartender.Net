using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.ItemMarket;

public class ItemMarketRoot {
    [JsonProperty ("itemmarket")]
    public required List<ItemListing> Items { get; set; }
}
using Bartender.Net.Framework.Market;
using Bartender.Net.Framework.Market.ItemMarket;

namespace Bartender.Net.Market.ItemMarket;

public class ItemListings : IItemListings {
    public required IEnumerable<IItemListing> Items { get; set; }
}
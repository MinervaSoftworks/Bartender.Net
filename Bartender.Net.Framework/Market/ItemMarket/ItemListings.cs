namespace Bartender.Net.Framework.Market.ItemMarket;

public class ItemListings : IItemListings {
    public required IEnumerable<IItemListing> Items { get; set; }
}
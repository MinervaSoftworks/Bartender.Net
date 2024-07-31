namespace Bartender.Net.Framework.Market.ItemMarket;

public class ItemListings : IItemListings {
    public IEnumerable<IItemListing> Items { get; }
}
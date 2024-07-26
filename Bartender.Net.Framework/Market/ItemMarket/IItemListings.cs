namespace Bartender.Net.Framework.Market.ItemMarket;

public interface IItemListings {
    IEnumerable<IItemListing> Items { get; }
}

namespace Bartender.Net.Framework.Market.Bazaar;

public interface IBazaarListings {
    IEnumerable<IItemListing> Items { get; set; }
}
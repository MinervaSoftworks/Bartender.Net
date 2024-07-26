namespace Bartender.Net.Framework.Market;

public interface IItemListing : IBartenderEntity {
    int Cost { get; }
    int Quantity { get; }
}
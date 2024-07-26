namespace Bartender.Net.Framework.Market;

public interface IItemListing : IBartenderEntity {
    int Cost { get; set; }
    int Quantity { get; set; }
}
namespace Bartender.Net.Framework.Market.PointsMarket;

public interface IPointListing : IBartenderEntity {
    int Cost { get; }
    int Quantity { get; }
    int TotalCost { get; }
}
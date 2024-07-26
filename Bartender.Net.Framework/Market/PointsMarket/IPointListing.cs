namespace Bartender.Net.Framework.Market.PointsMarket;

public interface IPointListing : IBartenderEntity {
    int Cost { get; set; }
    int Quantity { get; set; }
    int TotalCost { get; set; }
}
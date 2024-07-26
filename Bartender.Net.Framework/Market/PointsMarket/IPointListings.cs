namespace Bartender.Net.Framework.Market.PointsMarket;

public interface IPointListings {
    IDictionary<string, IPointListing> Points { get; set; }
}
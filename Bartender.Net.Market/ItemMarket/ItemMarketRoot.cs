namespace Bartender.Net.Market.ItemMarket;

public class ItemMarketRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    public required List<ItemListing> Items { get; set; }
}
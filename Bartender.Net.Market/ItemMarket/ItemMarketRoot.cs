using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.ItemMarket;

public class ItemMarketRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("itemmarket")]
    public virtual required List<ItemListing> Items { get; set; }
}
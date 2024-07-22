using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class ItemMarket {
    [JsonProperty("itemmarket")]
    public IEnumerable<MarketItem> Items { get; set; }
}

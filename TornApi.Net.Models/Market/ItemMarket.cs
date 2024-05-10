using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class ItemMarket {
    [JsonProperty("itemmarket")]
    public IEnumerable<Item> Items { get; set; }
}

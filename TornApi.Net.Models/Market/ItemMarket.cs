using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class ItemMarket {
    [JsonProperty("itmemarket")]
    public IEnumerable<Item> Items { get; set; }
}

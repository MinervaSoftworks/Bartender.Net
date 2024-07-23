using Bartender.Net.Framework.User.Bazaar;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class BazaarListing : IBazaarListing {
    [JsonProperty ("ID")]
    public required int ID { get; set; }

    [JsonIgnore]
    public UserProfile Owner { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("price")]
    public required int Price { get; set; }

    [JsonProperty ("market_price")]
    public required int MarketPrice { get; set; }
}

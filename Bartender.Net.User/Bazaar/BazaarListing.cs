using Bartender.Net.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class BazaarListing {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonIgnore]
    public UserProfileRoot? Owner { get; set; }

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

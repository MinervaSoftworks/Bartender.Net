using Bartender.Net.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class BazaarListing {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonIgnore]
    public ProfileRoot Owner { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("price")]
    public int Price { get; set; }

    [JsonProperty ("market_price")]
    public int MarketPrice { get; set; }
}

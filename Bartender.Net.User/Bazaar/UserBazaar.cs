using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class UserBazaar {
    [JsonProperty ("bazaar")]
    public required List<BazaarListing> Listings { get; set; }
}

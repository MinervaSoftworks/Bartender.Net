using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class BazaarRoot {
    [JsonProperty ("bazaar")]
    public required List<BazaarListing> Listings { get; set; }
}

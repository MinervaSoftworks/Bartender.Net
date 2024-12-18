using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class BazaarRoot : BartenderEntity {
    [JsonProperty ("bazaar")]
    public virtual required List<BazaarListing> Listings { get; set; }
}

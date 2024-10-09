using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class BazaarRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bazaar")]
    public virtual required List<BazaarListing> Listings { get; set; }
}

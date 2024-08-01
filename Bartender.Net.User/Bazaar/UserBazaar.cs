using Bartender.Net.Framework.User.Bazaar;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bazaar;

public class UserBazaar : IUserBazaar {
    [JsonProperty ("bazaar")]
    public List<IBazaarListing> Listings { get; set; }
}

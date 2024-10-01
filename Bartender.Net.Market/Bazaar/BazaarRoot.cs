using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.Bazaar;

public class BazaarRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bazaar")]
    public required List<ItemListing> Items { get; set; }
}

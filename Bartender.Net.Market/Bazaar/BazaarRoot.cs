using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.Bazaar;

public class BazaarRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("bazaar")]
    public virtual required List<ItemListing> Items { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("merits")]
    public virtual required UserMerits Merits { get; set; }
}

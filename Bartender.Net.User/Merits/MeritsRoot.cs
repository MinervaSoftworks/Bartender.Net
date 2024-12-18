using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritsRoot : BartenderEntity {
    [JsonProperty ("merits")]
    public virtual required UserMerits Merits { get; set; }
}

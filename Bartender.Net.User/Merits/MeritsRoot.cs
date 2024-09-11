using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritsRoot {
    [JsonProperty ("merits")]
    public required UserMerits Merits { get; set; }
}

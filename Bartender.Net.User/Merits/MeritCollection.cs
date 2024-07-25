using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritCollection : IMeritCollection {
    [JsonProperty ("merits")]
    public required UserMerits Merits { get; set; }
}

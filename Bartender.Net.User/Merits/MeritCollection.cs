using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritCollection : IMeritCollection {
    [JsonProperty ("merits")]
    public UserMerits Merits { get; set; }
}

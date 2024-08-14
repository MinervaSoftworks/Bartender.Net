using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritCollection {
    [JsonProperty ("merits")]
    public UserMerits Merits { get; set; }
}

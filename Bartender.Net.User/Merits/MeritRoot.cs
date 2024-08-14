using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritRoot {
    [JsonProperty ("merits")]
    public UserMerits Merits { get; set; }
}

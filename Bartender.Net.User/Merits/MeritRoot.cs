using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritRoot {
    [JsonProperty ("merits")]
    public required UserMerits Merits { get; set; }
}

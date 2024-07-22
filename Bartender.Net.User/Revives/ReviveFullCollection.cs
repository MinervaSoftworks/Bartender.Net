using Newtonsoft.Json;

namespace Bartender.Net.User.Revives;

public class ReviveFullCollection {
    [JsonProperty ("revives")]
    public required IDictionary<string, ReviveFull> Revives { get; set; }
}

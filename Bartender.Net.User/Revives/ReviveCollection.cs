using Newtonsoft.Json;

namespace Bartender.Net.User.Revives;

public class ReviveCollection {
    [JsonProperty("revives")]
    public required IDictionary<string, Revive> Revives { get; set; }
}

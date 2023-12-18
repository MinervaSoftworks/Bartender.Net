using Newtonsoft.Json;

namespace TornApi.Net.Models.Key;

internal class Info {
    [JsonProperty ("access_level")]
    public int AccessLevel { get; set; }

    [JsonProperty ("access_type")]
    public AccessType AccessType { get; set; }

    [JsonProperty ("selections")]
    public Selections Selections { get; set; }
}

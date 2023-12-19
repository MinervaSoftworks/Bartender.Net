using Newtonsoft.Json;

namespace TornApi.Net.Models.Key;

public class KeyInfo {
    [JsonProperty ("access_level")]
    public int AccessLevel { get; set; }

    [JsonProperty ("access_type")]
    public AccessLevel AccessType { get; set; }

    [JsonProperty ("selections")]
    public Selections Selections { get; set; }
}

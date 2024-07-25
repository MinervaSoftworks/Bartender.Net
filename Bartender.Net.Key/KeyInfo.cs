using Bartender.Net.Framework.Sections;
using Bartender.Net.Framework.Key;
using Newtonsoft.Json;

namespace TornApi.Net.Models.Key;

public class KeyInfo : IKeyInfo {
    [JsonProperty ("access_level")]
    public required int ID { get; set; }

    [JsonProperty ("access_type")]
    public required string AccessLevelString { get; set; }

    [JsonIgnore]
    public AccessLevel AccessLevel {
        get => (AccessLevel) ID;
        set => ID = (int) value;
    }

    [JsonProperty ("selections")]
    public required IKeySelections Selections { get; set; }
}

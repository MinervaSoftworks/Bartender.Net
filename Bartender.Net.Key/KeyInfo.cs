using Bartender.Net.Framework.Selection;
using Newtonsoft.Json;

namespace Bartender.Net.Key;

public class KeyInfo {
    [JsonProperty ("access_level")]
    public int ID { get; set; }

    [JsonProperty ("access_type")]
    public required string AccessLevelString { get; set; }

    [JsonIgnore]
    public AccessLevel AccessLevel {
        get => (AccessLevel) ID;
        set => ID = (int) value;
    }

    [JsonProperty ("selections")]
    public KeySelections Selections { get; set; }
}

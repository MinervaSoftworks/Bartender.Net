using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Newtonsoft.Json;

namespace TornApi.Net.Models.Key;

public class KeyInfo : IKeyInfo {
    [JsonProperty ("access_level")]
    public int ID { get; set; }

    [JsonProperty ("access_type")]
    public string AccessLevelString { get; set; }

    [JsonIgnore]
    public AccessLevel AccessLevel {
        get => (AccessLevel) ID;
        set => ID = (int) value;
    }

    [JsonProperty ("selections")]
    public IKeySelections Selections { get; set; }
}

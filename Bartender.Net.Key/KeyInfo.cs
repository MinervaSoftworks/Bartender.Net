using Bartender.Net.Framework;
using Bartender.Net.Framework.Key;
using Newtonsoft.Json;

namespace Bartender.Net.Key;

public class KeyInfo : BartenderEntity {
    [JsonProperty ("access_level")]    public required int AccessLevelID {
        get => TornID;
        set => TornID = value;
    }

    [JsonProperty ("access_type")]
    public required string AccessLevelString { get; set; }

    [JsonIgnore]
    public AccessLevel AccessLevel {
        get => (AccessLevel) AccessLevelID;
        set => AccessLevelID  = (int) value;
    }

    [JsonProperty ("selections")]
    public virtual required KeyAuths Selections { get; set; }
}

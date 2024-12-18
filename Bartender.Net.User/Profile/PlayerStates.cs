using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class PlayerStates : BartenderEntity {
    [JsonProperty ("hospital_timestamp")]
    public required long HospitalTimestamp { get; set; }

    [JsonProperty ("jail_timestamp")]
    public required long JailTimestamp { get; set; }
}

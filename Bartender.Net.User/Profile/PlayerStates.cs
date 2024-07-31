using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class PlayerStates : IPlayerStates {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("hospital_timestamp")]
    public long HospitalTimestamp { get; set; }

    [JsonProperty ("jail_timestamp")]
    public long JailTimestamp { get; set; }
}

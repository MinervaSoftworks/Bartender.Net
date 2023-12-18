using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class PlayerStates {
    [JsonProperty ("hospital_timestamp")]
    public long HospitalTimestamp { get; set; }

    [JsonProperty ("jail_timestamp")]
    public long JailTimestamp { get; set; }
}

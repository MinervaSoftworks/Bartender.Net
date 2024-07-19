using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Staff {
    [JsonProperty("maid")]
    public int Maid { get; set; }

    [JsonProperty("guard")]
    public int Guard { get; set; }

    [JsonProperty("pilot")]
    public int Pilot { get; set; }

    [JsonProperty("butler")]
    public int Butler { get; set; }

    [JsonProperty("doctor")]
    public int Doctor { get; set; }
}

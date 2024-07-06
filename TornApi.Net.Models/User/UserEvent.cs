using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class UserEvent {
    [JsonProperty("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty("event")]
    public string Event { get; set; }
}

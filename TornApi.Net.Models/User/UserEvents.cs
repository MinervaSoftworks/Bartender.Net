using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class UserEvents {
    [JsonProperty("events")]
    public Dictionary<string, UserEvent> Events { get; set; }
}

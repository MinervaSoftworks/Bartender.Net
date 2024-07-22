using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class UserEvent {
    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("event")]
    public required string Event { get; set; }
}

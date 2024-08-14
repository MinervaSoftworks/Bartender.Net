using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class UserEvent {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty ("event")]
    public string Event { get; set; }
}

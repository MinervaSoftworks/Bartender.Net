using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class Event {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("event")]
    public required string Message { get; set; }
}

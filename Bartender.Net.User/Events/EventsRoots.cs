using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class EventsRoots {
    [JsonProperty ("events")]
    public required Dictionary<string, Event> Events { get; set; }
}

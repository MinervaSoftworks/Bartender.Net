using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class EventsRoot {
    [JsonProperty ("events")]
    public required Dictionary<string, Event> Events { get; set; }
}

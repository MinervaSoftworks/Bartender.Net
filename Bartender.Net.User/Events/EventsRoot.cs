using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class EventsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("events")]
    public required Dictionary<string, Event> Events { get; set; }
}

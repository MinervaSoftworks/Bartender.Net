using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class EventsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("events")]
    public required Dictionary<string, Event> Events { get; set; }
}

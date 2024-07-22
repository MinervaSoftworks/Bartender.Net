using Bartender.Net.User.Events;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEvent : UserEvent {
    [JsonProperty("seen")]
    public required bool Seen { get; set; }
}

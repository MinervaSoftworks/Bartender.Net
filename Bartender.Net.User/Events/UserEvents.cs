using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class UserEvents {
    [JsonProperty ("events")]
    public Dictionary<string, UserEvent> Events { get; set; }
}

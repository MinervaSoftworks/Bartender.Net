using Bartender.Net.Framework.User.Events;
using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class UserEvents : IUserEvents {
    [JsonProperty ("events")]
    public Dictionary<string, IUserEvent> Events { get; set; }
}

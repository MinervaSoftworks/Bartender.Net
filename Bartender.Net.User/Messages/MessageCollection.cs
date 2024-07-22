using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class MessageCollection {
    [JsonProperty ("messages")]
    public required IDictionary<string, Message> Messages { get; set; }
}

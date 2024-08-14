using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class UserMessageCollection {
    [JsonProperty ("messages")]
    public Dictionary<string, UserMessage> Messages { get; set; }
}

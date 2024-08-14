using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class UserMessages {
    [JsonProperty ("messages")]
    public required Dictionary<string, UserMessage> Messages { get; set; }
}

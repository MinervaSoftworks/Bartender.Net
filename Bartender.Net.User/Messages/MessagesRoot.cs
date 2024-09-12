using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class MessagesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("messages")]
    public required Dictionary<string, UserMessage> Messages { get; set; }
}

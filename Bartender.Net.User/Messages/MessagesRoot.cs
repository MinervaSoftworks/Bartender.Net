using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class MessagesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("messages")]
    public required Dictionary<string, UserMessage> Messages { get; set; }
}

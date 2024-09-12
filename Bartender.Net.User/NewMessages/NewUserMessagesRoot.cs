using Bartender.Net.User.Messages;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessagesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("messages")]
    public required Dictionary<string, UserMessage> Messages { get; set; }

    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }
}
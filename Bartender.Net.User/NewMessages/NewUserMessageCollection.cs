using Bartender.Net.User.Messages;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessageCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("messages")]
    public Dictionary<string, UserMessage> Messages { get; set; }

    [JsonProperty ("player_id")]
    public int PlayerID { get; set; }
}
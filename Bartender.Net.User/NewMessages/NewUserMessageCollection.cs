using Bartender.Net.User.Messages;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessageCollection : MessageCollection {
    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }
}
using Bartender.Net.Framework.User.Messages;
using Bartender.Net.Framework.User.NewMessages;
using Bartender.Net.User.Messages;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessageCollection : INewUserMessageCollection {
    [JsonProperty ("messages")]
    public required IDictionary<string, INewUserMessage> Messages { get; set; }

    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }
}
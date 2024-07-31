using Bartender.Net.Framework.User.NewMessages;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessageCollection : INewUserMessageCollection {
    [JsonProperty ("messages")]
    public IDictionary<string, INewUserMessage> Messages { get; set; }

    [JsonProperty ("player_id")]
    public int PlayerID { get; set; }
}
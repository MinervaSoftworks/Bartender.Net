using Bartender.Net.Framework.User.Messages;
using Bartender.Net.Framework.User.NewMessages;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessageCollection : INewUserMessageCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("messages")]
    public IDictionary<string, IUserMessage> Messages { get; set; }

    [JsonProperty ("player_id")]
    public int PlayerID { get; set; }
}
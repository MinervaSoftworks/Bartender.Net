using Bartender.Net.Framework.User.NewEvents;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEventCollection : INewUserEventCollection {
    [JsonProperty ("events")]
    public IDictionary<string, INewUserEvent> Events { get; set; }

    [JsonProperty ("player_id")]
    public int PlayerID { get; set; }
}

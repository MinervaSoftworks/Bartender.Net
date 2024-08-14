using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEventCollection {
    [JsonProperty ("events")]
    public Dictionary<string, NewUserEvent> Events { get; set; }

    [JsonProperty ("player_id")]
    public int PlayerID { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEventCollection {
    [JsonProperty("events")]
    public required IDictionary<string, NewUserEvent> Events { get; set; }

    [JsonProperty("player_id")]
    public required int PlayerID { get; set; }
}

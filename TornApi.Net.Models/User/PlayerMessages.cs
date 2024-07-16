using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class PlayerMessages {
    [JsonProperty("player_id")]
    public int PlayerId { get; set; }

    [JsonProperty("messages")]
    public IDictionary<string, Message> Messages { get; set; }
}

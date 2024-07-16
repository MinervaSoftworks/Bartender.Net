using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Notifications {
    [JsonProperty("messages")]
    public int Messages { get; set; }

    [JsonProperty("events")]
    public int Events { get; set; }

    [JsonProperty("awards")]
    public int Awards { get; set; }

    [JsonProperty("competition")]
    public int Competition { get; set; }
}
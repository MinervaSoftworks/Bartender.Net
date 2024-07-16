using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Discord {
    [JsonProperty("userID")]
    public int UserID { get; set; }

    [JsonProperty("discordID")]
    public string DiscordID { get; set; }
}

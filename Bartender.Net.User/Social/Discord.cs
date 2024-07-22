using Newtonsoft.Json;

namespace Bartender.Net.User.Social;

public class DiscordRecord {
    [JsonProperty ("userID")]
    public required int UserID { get; set; }

    [JsonProperty ("discordID")]
    public required string DiscordID { get; set; }
}

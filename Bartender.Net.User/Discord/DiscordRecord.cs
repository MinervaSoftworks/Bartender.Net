using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Discord;

public class DiscordRecord : BartenderEntity {
    [JsonProperty ("userID")]
    public required int UserID { get; set; }

    [JsonProperty ("discordID")]
    public required string DiscordID { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Discord;

public class DiscordRecord : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("userID")]
    public required int UserID { get; set; }

    [JsonProperty ("discordID")]
    public required string DiscordID { get; set; }
}

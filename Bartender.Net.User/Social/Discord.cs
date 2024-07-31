using Bartender.Net.Framework.User.Social;
using Newtonsoft.Json;

namespace Bartender.Net.User.Social;

public class DiscordRecord : IDiscordRecord {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("userID")]
    public int UserID { get; set; }

    [JsonProperty ("discordID")]
    public string DiscordID { get; set; }
}

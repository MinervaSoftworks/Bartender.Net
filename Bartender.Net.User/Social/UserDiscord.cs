using Newtonsoft.Json;

namespace Bartender.Net.User.Social;

public class UserDiscord {
    [JsonProperty ("discord")]
    public required DiscordRecord Discord { get; set; }
}

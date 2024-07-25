using Bartender.Net.Framework.User.Social;
using Newtonsoft.Json;

namespace Bartender.Net.User.Social;

public class UserDiscord : IUserDiscord {
    [JsonProperty ("discord")]
    public required IDiscordRecord Discord { get; set; }
}

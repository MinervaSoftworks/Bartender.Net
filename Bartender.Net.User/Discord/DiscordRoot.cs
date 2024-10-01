using Newtonsoft.Json;

namespace Bartender.Net.User.Discord;

//TODO can just move this into it's own folder
public class DiscordRoot {
    [JsonProperty ("discord")]
    public required DiscordRecord Discord { get; set; }
}

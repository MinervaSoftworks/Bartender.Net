using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Discord;

public class DiscordRoot : BartenderEntity {
    [JsonProperty ("discord")]
    public virtual required DiscordRecord Discord { get; set; }
}

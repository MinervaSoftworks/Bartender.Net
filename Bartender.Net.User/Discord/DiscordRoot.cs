using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Discord;

public class DiscordRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("discord")]
    public required DiscordRecord Discord { get; set; }
}

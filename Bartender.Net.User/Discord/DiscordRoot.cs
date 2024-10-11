using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Discord;

public class DiscordRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("discord")]
    public virtual required DiscordRecord Discord { get; set; }
}

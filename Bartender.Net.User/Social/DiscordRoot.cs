using Bartender.Net.Framework;
using Bartender.Net.Framework.User.Social;
using Newtonsoft.Json;

namespace Bartender.Net.User.Social;

//TODO can just move this into it's own folder
public class DiscordRoot : IDiscordRoot {
    [JsonProperty ("discord")]
    [JsonConverter (typeof(ConcreteConverter<DiscordRecord>))]
    public required IDiscordRecord Discord { get; set; }
}

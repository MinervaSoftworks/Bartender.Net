using Bartender.Net.Framework.User.Cooldowns;
using Newtonsoft.Json;

namespace Bartender.Net.User.UserCooldowns;

public class UserCooldownsCollection : IUserCooldownsCollection {
    [JsonProperty ("cooldowns")]
    public required IUserCooldowns Cooldowns { get; set; }
}

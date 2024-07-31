using Bartender.Net.Framework.User.Cooldowns;
using Newtonsoft.Json;

namespace Bartender.Net.User.UserCooldowns;

public class UserCooldownsCollection : IUserCooldownsCollection {
    [JsonProperty ("cooldowns")]
    public IUserCooldowns Cooldowns { get; set; }
}

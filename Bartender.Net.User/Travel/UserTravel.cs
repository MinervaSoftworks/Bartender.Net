using Bartender.Net.Framework.User.Travel;
using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class UserTravel : IUserTravel {
    [JsonProperty ("travel")]
    public required ITravelEntry Travel { get; set; }
}

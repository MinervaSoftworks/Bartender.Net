using Newtonsoft.Json;

namespace Bartender.Net.User.Gym;

public class Gym {
    [JsonProperty ("active_gym")]
    public required int ActiveGym { get; set; }
}

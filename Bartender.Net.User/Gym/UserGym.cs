using Newtonsoft.Json;

namespace Bartender.Net.User.Gym;

public class UserGym {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("active_gym")]
    public required int ActiveGym { get; set; }
}

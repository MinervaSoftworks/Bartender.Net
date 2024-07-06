using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Gym {
    [JsonProperty("active_gym")]
    public int ActiveGym { get; set; }
}

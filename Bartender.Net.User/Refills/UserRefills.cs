using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class UserRefills {
    [JsonProperty ("refills")]
    public required RefillStates Refills { get; set; }
}

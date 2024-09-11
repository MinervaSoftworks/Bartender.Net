using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillsRoot {
    [JsonProperty ("refills")]
    public required RefillStates Refills { get; set; }
}

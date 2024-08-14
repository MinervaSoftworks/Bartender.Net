using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillRoot {
    [JsonProperty ("refills")]
    public required RefillStates Refills { get; set; }
}

using Bartender.Net.Framework.User.Refills;
using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillRoot : IRefillRoot {
    [JsonProperty ("refills")]
    public required IRefillStates Refills { get; set; }
}

using Bartender.Net.Framework;
using Bartender.Net.Framework.User.Refills;
using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillRoot : IRefillRoot {
    [JsonProperty ("refills")]
    [JsonConverter (typeof(ConcreteConverter<RefillStates>))]
    public required IRefillStates Refills { get; set; }
}

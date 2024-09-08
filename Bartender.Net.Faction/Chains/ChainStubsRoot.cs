using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class ChainStubsRoot {
    [JsonProperty ("chains")]
    public required Dictionary<string, ChainStub> Chains { get; set; }
}

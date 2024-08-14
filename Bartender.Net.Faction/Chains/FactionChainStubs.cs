using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class FactionChainStubs {
    [JsonProperty ("chains")]
    public required Dictionary<string, ChainStub> Chains { get; set; }
}

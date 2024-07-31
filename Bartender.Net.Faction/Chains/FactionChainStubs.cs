using Bartender.Net.Framework.Faction.Chains;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class FactionChainStubs : IFactionChainStubs {
    [JsonProperty ("chains")]
    public IDictionary<string, IChainStub> Chains { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chain;

public class CurrentFactionChain {
    [JsonProperty ("chain")]
    public CurrentChainEntry Chain { get; set; }
}

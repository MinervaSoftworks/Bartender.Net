using Bartender.Net.Framework.Faction.Chain;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chain;

public class CurrentFactionChain : ICurrentFactionChain {
    [JsonProperty ("chain")]
    public ICurrentChainEntry Chain { get; set; }
}

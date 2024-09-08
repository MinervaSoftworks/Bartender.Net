using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chain;

public class ChainRoot {
    [JsonProperty ("chain")]
    public CurrentChainEntry Chain { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chain;

public class ChainRoot {
    [JsonProperty ("chain")]
    public required CurrentChainEntry Chain { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chain;

public class ChainRoot : BartenderEntity {
    [JsonProperty ("chain")]
    public required CurrentChain Chain { get; set; }
}

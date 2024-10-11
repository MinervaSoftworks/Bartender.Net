using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chain;

public class ChainRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("chain")]
    public required CurrentChain Chain { get; set; }
}

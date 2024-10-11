using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class ChainsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("chains")]
    public required Dictionary<string, FactionChain> Chains { get; set; }
}

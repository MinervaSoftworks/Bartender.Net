using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class ChainsRoot {
    [JsonProperty ("chains")]
    public required Dictionary<string, FactionChain> Chains { get; set; }
}

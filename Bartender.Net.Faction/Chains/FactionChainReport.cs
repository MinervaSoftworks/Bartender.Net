using Bartender.Net.Framework.Faction.Chains;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class ChainStub : IChainStub {
    [JsonProperty ("userID")]
    public int ID { get; set; }

    [JsonProperty ("chain")]
    public int Chain { get; set; }

    [JsonProperty ("respect")]
    public string Respect { get; set; }

    [JsonProperty ("start")]
    public int Start { get; set; }

    [JsonProperty ("end")]
    public int End { get; set; }
}

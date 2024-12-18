using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class FactionChain : BartenderEntity {
    [JsonProperty ("userID")]    public required int FactionChainID {
        get => TornID;
        set => TornID = value;
    }

    [JsonProperty ("chain")]
    public required int ChainNumber { get; set; }

    [JsonProperty ("respect")]
    public required string Respect { get; set; }

    [JsonProperty ("start")]
    public required int Start { get; set; }

    [JsonProperty ("end")]
    public required int End { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionBasicRankedWarFaction : BartenderEntity {
    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("score")]
    public required int Score { get; set; }
}

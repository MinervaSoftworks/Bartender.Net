using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarFaction : BartenderEntity {
    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("name")]
    public required int Name { get; set; }

    [JsonProperty ("score")]
    public required int Score { get; set; }
}
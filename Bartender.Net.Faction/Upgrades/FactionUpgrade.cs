using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Upgrades;

public class FactionUpgrade : BartenderEntity {
    [JsonProperty ("ability")]
    public required string Ability { get; set; }

    [JsonProperty ("basecost")]
    public required int BaseCost { get; set; }

    [JsonProperty ("branch")]
    public required string Branch { get; set; }

    [JsonProperty ("branchmultiplier")]
    public required int BranchMultiplier { get; set; }

    [JsonProperty ("branchorder")]
    public required int BranchOrder { get; set; }

    [JsonProperty ("can_be_set")]
    public bool CanBeSet { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("unlocked")]
    public DateTime Unlocked { get; set; }
}

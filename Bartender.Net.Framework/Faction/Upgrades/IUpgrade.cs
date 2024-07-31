using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.Upgrades;

public interface IUpgrade : IBartenderEntity {
    [JsonProperty ("ability")]
    string Ability { get; set; }

    [JsonProperty ("basecost")]
    int BaseCost { get; set; }

    [JsonProperty ("branch")]
    string Branch { get; set; }

    [JsonProperty ("branchmultiplier")]
    int BranchMultiplier { get; set; }

    [JsonProperty ("branchorder")]
    int BranchOrder { get; set; }

    [JsonProperty ("can_be_set")]
    bool CanBeSet { get; set; }

    [JsonProperty ("level")]
    int Level { get; set; }

    [JsonProperty ("name")]
    string Name { get; set; }

    [JsonProperty ("unlocked")]
    DateTime Unlocked { get; set; }
}

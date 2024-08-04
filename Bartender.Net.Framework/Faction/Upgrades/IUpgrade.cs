using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.Upgrades;

public interface IUpgrade : IBartenderEntity {
    [JsonProperty ("ability")]
    string Ability { get; }

    [JsonProperty ("basecost")]
    int BaseCost { get; }

    [JsonProperty ("branch")]
    string Branch { get; }

    [JsonProperty ("branchmultiplier")]
    int BranchMultiplier { get; }

    [JsonProperty ("branchorder")]
    int BranchOrder { get; }

    [JsonProperty ("can_be_set")]
    bool CanBeSet { get; }

    [JsonProperty ("level")]
    int Level { get; }

    [JsonProperty ("name")]
    string Name { get; }

    [JsonProperty ("unlocked")]
    DateTime Unlocked { get; }
}

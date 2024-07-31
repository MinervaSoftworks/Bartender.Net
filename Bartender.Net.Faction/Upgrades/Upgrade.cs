using Bartender.Net.Framework.Faction.Upgrades;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Upgrades;

public class Upgrade : IUpgrade {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("ability")]
    public string Ability { get; set; }

    [JsonProperty ("basecost")]
    public int BaseCost { get; set; }

    [JsonProperty ("branch")]
    public string Branch { get; set; }

    [JsonProperty ("branchmultiplier")]
    public int BranchMultiplier { get; set; }

    [JsonProperty ("branchorder")]
    public int BranchOrder { get; set; }

    [JsonProperty ("can_be_set")]
    public bool CanBeSet { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("unlocked")]
    public DateTime Unlocked { get; set; }
}

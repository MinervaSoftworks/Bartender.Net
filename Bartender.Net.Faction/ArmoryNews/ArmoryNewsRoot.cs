using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ArmoryNews;

public class ArmoryNewsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("armorynews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

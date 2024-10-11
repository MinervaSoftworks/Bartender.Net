using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ArmoryNews;

public class ArmoryNewsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("armorynews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

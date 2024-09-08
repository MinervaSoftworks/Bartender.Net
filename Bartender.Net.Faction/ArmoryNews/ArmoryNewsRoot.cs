using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ArmoryNews;

public class ArmoryNewsRoot {
    [JsonProperty ("armorynews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

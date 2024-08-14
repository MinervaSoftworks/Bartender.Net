using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ArmoryNews;

public class ArmoryNewsCollection {
    [JsonProperty ("armorynews")]
    public Dictionary<string, NewsEntry> News { get; set; }
}

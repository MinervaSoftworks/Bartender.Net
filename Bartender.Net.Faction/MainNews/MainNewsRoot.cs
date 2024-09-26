using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.MainNews;

public class MainNewsRoot {
    [JsonProperty ("mainnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

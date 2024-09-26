using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class AttackNewsRoot {
    [JsonProperty ("attacknews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}


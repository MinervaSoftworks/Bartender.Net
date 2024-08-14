using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttackNews {
    [JsonProperty ("attacknews")]
    public Dictionary<string, NewsEntry> News { get; set; }
}


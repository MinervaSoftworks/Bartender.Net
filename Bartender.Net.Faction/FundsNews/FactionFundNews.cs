using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionFundNews {
    [JsonProperty ("fundsnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}


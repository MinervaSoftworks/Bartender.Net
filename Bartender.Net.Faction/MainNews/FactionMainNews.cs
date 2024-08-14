using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionMainNews {
    [JsonProperty ("mainnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

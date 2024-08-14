using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionTerritoryNews {
    [JsonProperty ("territorynews")]
    public Dictionary<string, NewsEntry> News { get; set; }
}


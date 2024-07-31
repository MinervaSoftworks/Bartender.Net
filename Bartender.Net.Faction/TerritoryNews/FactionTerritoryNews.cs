using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionTerritoryNews : INewsEntries {
    [JsonProperty ("territorynews")]
    public IDictionary<string, INewsEntry> News { get; set; }
}


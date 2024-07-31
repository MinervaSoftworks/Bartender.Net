using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionTerritoryNews : IFactionNews {
    [JsonProperty ("territorynews")]
    public IDictionary<string, IFactionNewsEntry> News { get; set; }
}


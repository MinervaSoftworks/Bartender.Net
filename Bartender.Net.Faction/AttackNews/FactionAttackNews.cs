using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttackNews : IFactionNews {
    [JsonProperty ("attacknews")]
    public IDictionary<string, IFactionNewsEntry> News { get; set; }
}


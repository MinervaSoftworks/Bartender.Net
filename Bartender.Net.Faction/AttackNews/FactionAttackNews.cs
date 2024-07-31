using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttackNews : INewsEntries {
    [JsonProperty ("attacknews")]
    public IDictionary<string, INewsEntry> News { get; set; }
}


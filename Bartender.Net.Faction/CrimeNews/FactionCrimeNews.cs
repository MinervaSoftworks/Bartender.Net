using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionCrimeNews {
    [JsonProperty ("crimenews")]
    public Dictionary<string, NewsEntry> News { get; set; }
}


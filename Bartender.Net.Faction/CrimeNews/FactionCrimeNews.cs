using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionCrimeNews : INewsEntries {
    [JsonProperty ("crimenews")]
    public IDictionary<string, INewsEntry> News { get; set; }
}


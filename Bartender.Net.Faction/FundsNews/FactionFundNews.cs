using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionFundNews : INewsEntries {
    [JsonProperty ("fundsnews")]
    public IDictionary<string, INewsEntry> News { get; set; }
}


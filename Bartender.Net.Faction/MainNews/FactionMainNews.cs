using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionMainNews : INewsEntries {
    [JsonProperty ("mainnews")]
    public IDictionary<string, INewsEntry> News { get; set; }
}

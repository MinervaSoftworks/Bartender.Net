using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionMainNews : IFactionNews {
    [JsonProperty ("mainnews")]
    public IDictionary<string, IFactionNewsEntry> News { get; set; }
}

using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionFundNews : IFactionNews {
    [JsonProperty ("fundsnews")]
    public IDictionary<string, IFactionNewsEntry> News { get; set; }
}


using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionCrimeNews : IFactionNews {
    [JsonProperty ("crimenews")]
    public IDictionary<string, IFactionNewsEntry> News { get; set; }
}


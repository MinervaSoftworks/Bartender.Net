using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeNews;

public class CrimeNewsRoot {
    [JsonProperty ("crimenews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}


using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.FundsNews;

public class FundsNewsRoot {
    [JsonProperty ("fundsnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}


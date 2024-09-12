using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.TerritoryNews;

public class TerritoryNewsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("territorynews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}


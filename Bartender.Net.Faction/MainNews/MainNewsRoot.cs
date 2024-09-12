using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.MainNews;

public class MainNewsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("mainnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

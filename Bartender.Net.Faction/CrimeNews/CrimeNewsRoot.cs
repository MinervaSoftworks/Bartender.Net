using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeNews;

public class CrimeNewsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("crimenews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}


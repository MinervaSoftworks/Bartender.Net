using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Common.News;

public class FactionNewsEntry : IFactionNewsEntry
{
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty("news")]
    public string News { get; set; }

    [JsonProperty("timestamp")]
    public long Timestamp { get; set; }
}

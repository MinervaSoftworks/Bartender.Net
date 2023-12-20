using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class NewsEntry {
    [JsonProperty ("news")]
    public string News { get; set; }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }
}

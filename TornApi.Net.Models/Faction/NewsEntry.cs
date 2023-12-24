using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class NewsEntry {
    public int FactionID { get; set; }

    [JsonProperty ("news")]
    public string News { get; set; }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }
}

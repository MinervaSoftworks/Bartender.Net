using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class ChainHistory {
    [JsonProperty ("chains")]
    public IDictionary<string, ChainEntry> Entries { get; set; }
}

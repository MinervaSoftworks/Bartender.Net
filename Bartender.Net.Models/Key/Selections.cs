using Newtonsoft.Json;

namespace TornApi.Net.Models.Key;

public class Selections {
    [JsonProperty ("company")]
    public IEnumerable<string> Company { get; set; }

    [JsonProperty ("faction")]
    public IEnumerable<string> Faction { get; set; }

    [JsonProperty ("Key")]
    public IEnumerable<string> Key { get; set; }

    [JsonProperty ("Market")]
    public IEnumerable<string> Market { get; set; }

    [JsonProperty ("Property")]
    public IEnumerable<string> Property { get; set; }

    [JsonProperty ("Torn")]
    public IEnumerable<string> Torn { get; set; }

    [JsonProperty ("User")]
    public IEnumerable<string> User { get; set; }
}

using Bartender.Net.Framework.Key;
using Newtonsoft.Json;

namespace Bartender.Net.Key;

public class KeySelections : IKeySelections {
    [JsonIgnore]
    public int ID { get; set; }

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

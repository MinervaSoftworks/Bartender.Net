using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Lookup {
    [JsonProperty("selections")]
    public IEnumerable<string> Selections { get; set; }
}

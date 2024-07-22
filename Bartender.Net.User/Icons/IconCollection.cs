using Newtonsoft.Json;

namespace Bartender.Net.User.Icons;

public class IconCollection {
    [JsonProperty ("icons")]
    public required IDictionary<string, string> Icons { get; set; }
}
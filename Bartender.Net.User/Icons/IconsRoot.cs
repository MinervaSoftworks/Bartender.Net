using Newtonsoft.Json;

namespace Bartender.Net.User.Icons;

public class IconsRoot {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("icons")]
    public required Dictionary<string, string> Icons { get; set; }
}
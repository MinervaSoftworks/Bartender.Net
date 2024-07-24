using Bartender.Net.Framework.User.Icons;
using Newtonsoft.Json;

namespace Bartender.Net.User.Icons;

public class IconCollection : IIconCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("icons")]
    public required IDictionary<string, string> Icons { get; set; }
}
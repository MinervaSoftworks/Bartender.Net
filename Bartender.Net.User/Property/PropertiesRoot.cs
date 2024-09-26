using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class PropertiesRoot {
    [JsonProperty ("properties")]
    public required Dictionary<string, UserProperty> Properties { get; set; }
}

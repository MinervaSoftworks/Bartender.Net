using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class UserProperties {
    [JsonProperty("properties")]
    public required IDictionary<string, UserProperty> Properties { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class PropertiesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("properties")]
    public required Dictionary<string, UserProperty> Properties { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class PropertiesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("properties")]
    public required Dictionary<string, UserProperty> Properties { get; set; }
}

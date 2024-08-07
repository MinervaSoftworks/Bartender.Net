using Bartender.Net.Framework;
using Bartender.Net.Framework.User.Property;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class PropertiesRoot : IPropertiesRoot {
    [JsonProperty ("properties")]
    [JsonConverter (typeof(ConcreteConverter<Dictionary<string, UserProperty>>))]
    public required IDictionary<string, IUserProperty> Properties { get; set; }
}

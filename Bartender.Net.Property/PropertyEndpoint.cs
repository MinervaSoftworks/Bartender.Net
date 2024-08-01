using Bartender.Net.Framework.Property;
using Bartender.Net.Framework.User.Property;
using Newtonsoft.Json;

namespace Bartender.Net.Property;

public class PropertyEndpoint : IPropertyEndpoint {
    [JsonProperty ("property")]
    public IUserProperty Property { get; set; }
}
using Bartender.Net.User.Property;
using Newtonsoft.Json;

namespace Bartender.Net.Property;

public class PropertyEndpoint {
    [JsonProperty ("property")]
    public UserProperty Property { get; set; }
}
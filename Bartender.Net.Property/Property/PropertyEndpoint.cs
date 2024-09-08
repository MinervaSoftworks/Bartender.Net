using Newtonsoft.Json;

namespace Bartender.Net.Property.Property;

public class PropertyEndpoint {
    [JsonProperty ("property")]
    public required PropertyEntry Property { get; set; }
}
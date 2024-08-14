using Newtonsoft.Json;

namespace Bartender.Net.Property;

public class PropertyEndpoint {
    [JsonProperty ("property")]
    public required PropertyEntry Property { get; set; }
}
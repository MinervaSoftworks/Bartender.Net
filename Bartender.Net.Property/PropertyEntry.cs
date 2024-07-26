using Newtonsoft.Json;

namespace Bartender.Net.Property;

public class PropertyEntry : IPropertyEntry {
    [JsonProperty ("property")]
    public required UserProperty Property { get; set; }
}
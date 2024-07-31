using Newtonsoft.Json;

namespace Bartender.Net.Property;

public class PropertyEntry : IPropertyEntry {
    [JsonProperty ("property")]
    public UserProperty Property { get; set; }
}
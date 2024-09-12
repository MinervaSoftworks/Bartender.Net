using Newtonsoft.Json;

namespace Bartender.Net.Property.Property;

public class PropertyRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("property")]
    public required PropertyEntry Property { get; set; }
}
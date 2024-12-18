using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Property.Property;

public class PropertyRoot : BartenderEntity {
    [JsonProperty ("property")]
    public required PropertyEntry Property { get; set; }
}
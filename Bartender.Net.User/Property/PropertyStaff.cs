using Bartender.Net.Framework.User.Property;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class PropertyStaff : IPropertyStaff {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("maid")]
    public int Maid { get; set; }

    [JsonProperty ("guard")]
    public int Guard { get; set; }

    [JsonProperty ("pilot")]
    public int Pilot { get; set; }

    [JsonProperty ("butler")]
    public int Butler { get; set; }

    [JsonProperty ("doctor")]
    public int Doctor { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class PropertyStaff : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("maid")]
    public required int Maid { get; set; }

    [JsonProperty ("guard")]
    public required int Guard { get; set; }

    [JsonProperty ("pilot")]
    public required int Pilot { get; set; }

    [JsonProperty ("butler")]
    public required int Butler { get; set; }

    [JsonProperty ("doctor")]
    public required int Doctor { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class Mission : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }

    [JsonIgnore]
    public string? Provider { get; set; }
}

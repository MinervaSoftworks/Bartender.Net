using Bartender.Net.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionMember {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("days_in_faction")]
    public required int DaysInFaction { get; set; }

    [JsonProperty ("last_action")]
    public LastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }

    [JsonProperty ("status")]
    public Status Status { get; set; }
}

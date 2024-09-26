using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionMember : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("days_in_faction")]
    public required int DaysInFaction { get; set; }

    [JsonProperty ("last_action")]
    public required LastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }

    [JsonProperty ("status")]
    public required Status Status { get; set; }
}

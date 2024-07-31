using Bartender.Net.Framework.Faction.Basic;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionMember : IFactionMember {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("days_in_faction")]
    public int DaysInFaction { get; set; }

    [JsonProperty ("last_action")]
    public ILastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }

    [JsonProperty ("status")]
    public IStatus Status { get; set; }
}

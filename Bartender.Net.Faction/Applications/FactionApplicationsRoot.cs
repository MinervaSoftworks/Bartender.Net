using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplicationsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("applications")]
    public required Dictionary<string, FactionApplication> Applications { get; set; }
}
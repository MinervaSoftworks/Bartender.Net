using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplicationsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("applications")]
    public required Dictionary<string, FactionApplication> Applications { get; set; }
}
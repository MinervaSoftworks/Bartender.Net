using Bartender.Net.Framework.Faction.Applications;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplications : IFactionApplications {
    [JsonProperty ("applications")]
    public IDictionary<string, IFactionApplication> Applications { get; set; }
}
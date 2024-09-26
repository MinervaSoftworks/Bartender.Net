using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class ApplicationsRoot {
    [JsonProperty ("applications")]
    public required Dictionary<string, Application> Applications { get; set; }
}
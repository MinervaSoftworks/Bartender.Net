using Bartender.Net.Framework;
using Bartender.Net.Framework.Faction.Contributors;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributor : IFactionStatContributor {
    [JsonProperty ("contributed")]
    public int Contributed { get; set; }

    [JsonProperty ("in_faction")]
    public int InFaction { get; set; }
}

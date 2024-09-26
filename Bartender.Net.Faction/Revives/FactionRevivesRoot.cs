using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Revives;

public class FactionRevivesRoot {
    [JsonProperty ("revives")]
    public required List<Revive> Revives { get; set; }
}

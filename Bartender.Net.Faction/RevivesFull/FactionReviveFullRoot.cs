using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.RevivesFull;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.RevivesFull;

public class FactionReviveFullRoot {
    [JsonProperty ("revives")]
    public required Dictionary<string, ReviveFull> Revives { get; set; }
}

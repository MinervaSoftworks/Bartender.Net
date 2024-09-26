using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Attacks;

public class FactionAttacksRoot {
    [JsonProperty ("attacks")]
    public required Dictionary<string, FactionAttack> Attacks { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Attacks;

public class FactionAttacksRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public required Dictionary<string, FactionAttack> Attacks { get; set; }
}

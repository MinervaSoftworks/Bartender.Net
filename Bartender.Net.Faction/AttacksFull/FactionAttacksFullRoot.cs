using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttacksFullRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public required Dictionary<string, FactionAttackFull> Stubs { get; set; }
}
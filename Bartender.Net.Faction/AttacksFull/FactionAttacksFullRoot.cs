using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttacksFullRoot {
    [JsonProperty ("attacks")]
    public required Dictionary<string, AttackStub> Stubs { get; set; }
}
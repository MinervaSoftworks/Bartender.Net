using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class AttacksFullRoot {
    [JsonProperty ("attacks")]
    public required Dictionary<string, AttackStub> Stubs { get; set; }
}
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttackStubs {
    [JsonProperty ("attacks")]
    public required Dictionary<string, FactionAttackStub> Stubs { get; set; }
}
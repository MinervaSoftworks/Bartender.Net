using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttackStubs {
    [JsonProperty ("attacks")]
    public Dictionary<string, FactionAttackStub> Stubs { get; set; }
}
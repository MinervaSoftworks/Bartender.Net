using Bartender.Net.Framework.Faction.AttacksFull;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttackStubs : IFactionAttackStubs {
    [JsonProperty ("attacks")]
    public Dictionary<string, IFactionAttackStub> Stubs { get; set; }
}
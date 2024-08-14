using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttacks {
    [JsonProperty ("attacks")]
    public required Dictionary<string, FactionAttack> Attacks { get; set; }
}

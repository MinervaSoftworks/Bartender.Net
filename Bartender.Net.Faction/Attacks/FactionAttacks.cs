using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttacks {
    [JsonProperty ("attacks")]
    public Dictionary<string, FactionAttack> Attacks { get; set; }
}

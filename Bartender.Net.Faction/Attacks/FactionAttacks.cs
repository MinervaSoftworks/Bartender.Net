using Bartender.Net.Framework.Faction.Attacks;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttacks : IFactionAttacks {
    [JsonProperty ("attacks")]
    public Dictionary<string, IFactionAttack> Attacks { get; set; }
}

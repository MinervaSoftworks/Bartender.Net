using Bartender.Net.Faction.Armor;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionBoosters {
    [JsonProperty ("boosters")]
    public required List<FactionArmoryItem> Items { get; set; }
}

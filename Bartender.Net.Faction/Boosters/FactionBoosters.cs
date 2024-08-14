using Bartender.Net.Faction.Armor;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionBoosters {
    [JsonProperty ("boosters")]
    public List<FactionArmoryItem> Items { get; set; }
}

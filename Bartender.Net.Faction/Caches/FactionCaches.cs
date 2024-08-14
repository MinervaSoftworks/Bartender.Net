using Bartender.Net.Faction.Armor;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionCaches {
    [JsonProperty ("caches")]
    public List<FactionArmoryItem> Items { get; set; }
}

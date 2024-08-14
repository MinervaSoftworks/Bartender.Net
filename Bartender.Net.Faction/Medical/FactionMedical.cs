using Bartender.Net.Faction.Armor;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionMedical {
    [JsonProperty ("medical")]
    public List<FactionArmoryItem> Items { get; set; }
}

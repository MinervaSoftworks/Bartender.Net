using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Drugs;

public class DrugsRoot : BartenderEntity {
    [JsonProperty ("caches")]
    public required List<FactionArmoryItem> Items { get; set; }
}

using Bartender.Net.Faction.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Caches;

public class CachesRoot {
    [JsonProperty ("caches")]
    public required List<FactionArmoryItem> Items { get; set; }
}

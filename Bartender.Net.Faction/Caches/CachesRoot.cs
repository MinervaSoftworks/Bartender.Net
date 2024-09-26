using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Caches;

public class CachesRoot {
    [JsonProperty ("caches")]
    public required List<FactionArmoryItem> Items { get; set; }
}

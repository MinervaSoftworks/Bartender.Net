using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Caches;

public class CachesRoot : BartenderEntity {
    [JsonProperty ("caches")]
    public virtual required List<FactionArmoryItem> Items { get; set; }
}

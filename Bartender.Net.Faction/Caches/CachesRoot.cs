using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Caches;

public class CachesRoot : BartenderEntity {
    [JsonProperty ("caches")]
    public virtual required List<FactionCache> Items { get; set; }
}

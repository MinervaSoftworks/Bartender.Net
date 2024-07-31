using Bartender.Net.Framework.Faction.Common;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionCaches : IFactionArmoryItems {
    [JsonProperty ("caches")]
    public IEnumerable<IFactionArmoryItem> Items { get; set; }
}

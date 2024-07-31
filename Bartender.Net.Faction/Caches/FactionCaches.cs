using Bartender.Net.Framework.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionCaches : IFactionArmoryItems {
    [JsonProperty ("caches")]
    public IEnumerable<IFactionArmoryItem> Items { get; set; }
}

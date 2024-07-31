using Bartender.Net.Framework.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionBoosters : IFactionArmoryItems {
    [JsonProperty ("boosters")]
    public IEnumerable<IFactionArmoryItem> Items { get; set; }
}

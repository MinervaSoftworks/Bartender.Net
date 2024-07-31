using Bartender.Net.Framework.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionMedical : IFactionArmoryItems {
    [JsonProperty ("medical")]
    public IEnumerable<IFactionArmoryItem> Items { get; set; }
}

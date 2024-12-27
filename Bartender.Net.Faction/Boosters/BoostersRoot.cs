using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class BoostersRoot : BartenderEntity {
    [JsonProperty ("boosters")]
    public virtual required List<FactionBooster> Items { get; set; }
}

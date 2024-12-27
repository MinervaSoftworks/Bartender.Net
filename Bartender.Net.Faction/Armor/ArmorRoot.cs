using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class ArmorRoot : BartenderEntity {
    [JsonProperty ("armor")]
    public virtual required List<FactionArmor> Items { get; set; }
}

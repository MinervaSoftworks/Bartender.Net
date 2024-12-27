using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Weapons;

public class WeaponsRoot : BartenderEntity {
    [JsonProperty ("weapons")]
    public virtual required List<FactionWeapon> Loanables { get; set; }
}

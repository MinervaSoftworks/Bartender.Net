using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class WeaponExpRoot : BartenderEntity {
    [JsonProperty ("weaponexp")]
    public virtual required WeaponExpEntry WeaponExp { get; set; }
}

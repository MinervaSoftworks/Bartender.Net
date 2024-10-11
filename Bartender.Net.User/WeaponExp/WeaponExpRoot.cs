using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class WeaponExpRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("weaponexp")]
    public virtual required WeaponExpEntry WeaponExp { get; set; }
}

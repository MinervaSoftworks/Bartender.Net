using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class WeaponExpRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("weaponexp")]
    public required WeaponExpEntry WeaponExp { get; set; }
}

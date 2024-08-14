using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class WeaponExpRoot {
    [JsonProperty ("weaponexp")]
    public required WeaponExpEntry WeaponExp { get; set; }
}

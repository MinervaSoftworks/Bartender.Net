using Bartender.Net.Framework.User.WeaponExp;
using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class UserWeaponExp : IUserWeaponExperience {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("weaponexp")]
    public IWeaponExperienceEntry WeaponExp { get; set; }
}

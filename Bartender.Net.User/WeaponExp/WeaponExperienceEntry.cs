using Bartender.Net.Framework.User.WeaponExp;
using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class WeaponExperienceEntry : IWeaponExperienceEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("itemID")]
    public int ItemID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("exp")]
    public int Exp { get; set; }
}

using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Ammunition;
using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class Ammo {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("ammoID")]
    public int AmmoID { get => ID; set => ID = value; }

    [JsonProperty ("equipped")]
    public bool Equipped { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("size")]
    public string Size { get; set; }

    [JsonIgnore]
    public AmmoSize AmmoSize {
        get => Size.ToAmmoSize ();
        set => Size = value.ToAmmoSizeString ();
    }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonIgnore]
    public AmmoType AmmoType {
        get => Type.ToAmmoType ();
        set => Type = value.ToAmmoTypeString ();
    }

    [JsonProperty ("typeID")]
    public int TypeID { get; set; }
}

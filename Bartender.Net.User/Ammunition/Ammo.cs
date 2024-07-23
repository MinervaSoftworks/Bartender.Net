using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Ammunition;
using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class Ammo : IAmmo {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("ammoID")]
    public required int AmmoID { get => ID; set => ID = value; }

    [JsonProperty ("equipped")]
    public required bool Equipped { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("size")]
    public required string Size { get; set; }

    [JsonIgnore]
    public required AmmoSize AmmoSize {
        get => Size.ToAmmoSize ();
        set => Size = value.ToAmmoSizeString ();
    }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonIgnore]
    public required AmmoType AmmoType {
        get => Type.ToAmmoType ();
        set => Type = value.ToAmmoTypeString ();
    }

    [JsonProperty ("typeID")]
    public required int TypeID { get; set; }
}

using Bartender.Net.Framework.User.Ammunition;
using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class AmmoCollection : IAmmoCollection {
    [JsonProperty ("ammo")]
    public required IEnumerable<IAmmo> Ammo { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class AmmoRoot {
    [JsonProperty ("ammo")]
    public List<Ammo> Ammo { get; set; }
}

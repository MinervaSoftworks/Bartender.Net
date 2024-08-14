using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class AmmoCollection {
    [JsonProperty ("ammo")]
    public List<Ammo> Ammo { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class AmmoCollection {
    [JsonProperty("ammo")]
    public required IEnumerable<Ammo> Ammo { get; set; }
}

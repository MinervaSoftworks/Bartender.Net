using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class AmmoRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("ammo")]
    public required List<Ammo> Ammo { get; set; }
}

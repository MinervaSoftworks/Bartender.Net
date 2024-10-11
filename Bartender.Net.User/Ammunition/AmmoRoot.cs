using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class AmmoRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("ammo")]
    public virtual required List<Ammo> Ammo { get; set; }
}

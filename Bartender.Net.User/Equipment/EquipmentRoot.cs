using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Equipment;

public class EquipmentRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("equipment")]
    public virtual required List<EquipmentEntry> Equipment { get; set; }
}

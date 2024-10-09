using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Equipment;

public class EquipmentRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("equipment")]
    public virtual required List<EquipmentEntry> Equipment { get; set; }
}

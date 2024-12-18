using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Equipment;

public class EquipmentRoot : BartenderEntity {
    [JsonProperty ("equipment")]
    public virtual required List<EquipmentEntry> Equipment { get; set; }
}

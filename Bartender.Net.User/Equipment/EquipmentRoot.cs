using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Equipment;

public class EquipmentRoot {
    [JsonProperty ("equipment")]
    public required List<EquipmentEntry> Equipment { get; set; }
}

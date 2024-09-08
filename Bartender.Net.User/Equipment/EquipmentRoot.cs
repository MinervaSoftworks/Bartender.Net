using Newtonsoft.Json;

namespace Bartender.Net.User.Equipment;

public class EquipmentRoot {
    [JsonProperty ("equipment")]
    public List<EquipmentEntry> Equipment { get; set; }
}

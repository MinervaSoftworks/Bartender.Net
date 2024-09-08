using Bartender.Net.Faction.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Medical;

public class MedicalRoot {
    [JsonProperty ("medical")]
    public required List<FactionArmoryItem> Items { get; set; }
}

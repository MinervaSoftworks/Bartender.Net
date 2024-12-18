using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Medical;

public class MedicalRoot : BartenderEntity {
    [JsonProperty ("medical")]
    public virtual required List<FactionArmoryItem> Items { get; set; }
}

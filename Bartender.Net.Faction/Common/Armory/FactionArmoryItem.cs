using Bartender.Net.Framework.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionArmoryItem : IFactionArmoryItem {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("type")]
    public int Type { get; set; }
}
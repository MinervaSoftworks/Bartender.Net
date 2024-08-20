using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionArmoryItem {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("type")]
    public required int Type { get; set; }
}
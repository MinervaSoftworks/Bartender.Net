using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionArmor : BartenderEntity {
    [JsonProperty ("available")]
    public int Available { get; set; }

    [JsonProperty ("ID")]
    public int ItemID { get => TornID; set => TornID = value; }

    [JsonProperty ("loaned")]
    public int Loaned { get; set; }

    [JsonProperty ("loaned_to")]
    public string? LoandTo { get; set; } = "";

    [JsonProperty ("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; } = string.Empty;
}

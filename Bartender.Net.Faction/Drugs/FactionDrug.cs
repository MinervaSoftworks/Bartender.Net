using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Drugs;

public class FactionDrug : BartenderEntity {
    [JsonProperty ("ID")]
    public int ItemID { get => TornID; set => TornID = value; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }
}

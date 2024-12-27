using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Weapons;

public class FactionWeapon : BartenderEntity {
    [JsonProperty ("ID")]
    public int ItemID { get => TornID; set => TornID = value; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("available")]
    public required int Available { get; set; }

    [JsonProperty ("loaned")]
    public required int Loaned { get; set; }

    [JsonProperty ("loaned_to")]
    public string? LoanedTo { get; set; } = "";
}

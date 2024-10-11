using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Territory;

public class TerritoryRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("territory")]
    public required Dictionary<string, FactionTerritory> Territories { get; set; }
}

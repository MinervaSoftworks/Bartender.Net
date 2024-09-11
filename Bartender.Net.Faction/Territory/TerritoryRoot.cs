using Newtonsoft.Json;

namespace Bartender.Net.Faction.Territory;

public class TerritoryRoot {
    [JsonProperty ("territory")]
    public required Dictionary<string, Territory> Territories { get; set; }
}

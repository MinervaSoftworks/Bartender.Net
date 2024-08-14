using Newtonsoft.Json;

namespace Bartender.Net.Faction.Positions;

public class FactionPositions {
    [JsonProperty ("positions")]
    public Dictionary<string, FactionPosition> Positions { get; set; }
}

using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Positions;

public class PositionsRoot {
    [JsonProperty ("positions")]
    public required Dictionary<string, Position> Positions { get; set; }
}

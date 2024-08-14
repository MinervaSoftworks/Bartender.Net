using Newtonsoft.Json;

namespace Bartender.Net.Faction.Stats;

public class FactionStats {
    [JsonProperty ("stats")]
    public FactionStatsEntry Stats { get; set; }
}

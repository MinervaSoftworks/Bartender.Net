using Newtonsoft.Json;

namespace Bartender.Net.Faction.Stats;

public class StatsRoot {
    [JsonProperty ("stats")]
    public StatsEntry Stats { get; set; }
}

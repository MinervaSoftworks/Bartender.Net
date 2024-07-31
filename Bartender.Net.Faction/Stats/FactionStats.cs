using Bartender.Net.Framework.Faction.Stats;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Stats;

public class FactionStats {
    [JsonProperty ("stats")]
    public IFactionStatsEntry Stats { get; set; }
}

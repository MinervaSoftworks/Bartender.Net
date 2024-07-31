using Bartender.Net.Framework.Faction.Basic;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class TerritoryWar : ITerritoryWar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("assaulting_faction")]
    public int AssaultingFaction { get; set; }

    [JsonProperty ("defending_faction")]
    public int DefendingFaction { get; set; }

    [JsonProperty ("end_time")]
    public long EndTime { get; set; }

    [JsonProperty ("required_score")]
    public int RequiredScore { get; set; }

    [JsonProperty ("score")]
    public int Score { get; set; }

    [JsonProperty ("start_time")]
    public long StartTime { get; set; }

    [JsonProperty ("territory")]
    public string Territory { get; set; }

    [JsonProperty ("territory_war_id")]
    public int TerritoryWarID { get; set; }
}

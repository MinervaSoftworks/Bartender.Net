using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class TerritoryWar : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("assaulting_faction")]
    public required int AssaultingFaction { get; set; }

    [JsonProperty ("defending_faction")]
    public required int DefendingFaction { get; set; }

    [JsonProperty ("end_time")]
    public required long EndTime { get; set; }

    [JsonProperty ("required_score")]
    public required int RequiredScore { get; set; }

    [JsonProperty ("score")]
    public required int Score { get; set; }

    [JsonProperty ("start_time")]
    public required long StartTime { get; set; }

    [JsonProperty ("territory")]
    public required string Territory { get; set; }

    [JsonProperty ("territory_war_id")]
    public required int TerritoryWarID { get; set; }
}

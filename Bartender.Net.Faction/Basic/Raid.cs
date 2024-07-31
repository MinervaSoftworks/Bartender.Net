using Bartender.Net.Framework.Faction.Basic;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class Raid : IRaid {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("defender_score")]
    public int DefenderScore { get; set; }

    [JsonProperty ("defending_faction")]
    public int DefenderFaction { get; set; }

    [JsonProperty ("raider_score")]
    public string RaiderScore { get; set; }

    [JsonProperty ("raiding_faction")]
    public int RaiderFaction { get; set; }

    [JsonProperty ("start_time")]
    public long StartTime { get; set; }
}

using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarFaction {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("chain")]
    public int Chain { get; set; }

    [JsonProperty ("name")]
    public int Name { get; set; }

    [JsonProperty ("score")]
    public int Score { get; set; }
}
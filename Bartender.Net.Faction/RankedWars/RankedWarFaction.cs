using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarFaction {
    [JsonIgnore]
    public  int ID { get; set; }

    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("name")]
    public required int Name { get; set; }

    [JsonProperty ("score")]
    public required int Score { get; set; }
}
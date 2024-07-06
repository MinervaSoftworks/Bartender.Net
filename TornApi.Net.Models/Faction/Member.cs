using Newtonsoft.Json;
using TornApi.Net.Models.User;

namespace TornApi.Net.Models.Faction;

public class Member {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public string ProfileID { get; set; }

    [JsonProperty ("days_in_faction")]
    public int DaysInFaction { get; set; }

    [JsonProperty ("last_action")]
    public LastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }

    [JsonProperty ("status")]
    public Status Status { get; set; }
}

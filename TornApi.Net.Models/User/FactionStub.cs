using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class FactionStub {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("days_in_faction")]
    public int DaysInFaction { get; set; }

    [JsonProperty ("faction_id")]
    public int FactionID { get; set; }

    [JsonProperty ("faction_name")]
    public string Name { get; set; }

    [JsonProperty ("faction_tag")]
    public string FactionTag { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }
}

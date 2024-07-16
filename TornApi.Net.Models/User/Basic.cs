using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Basic {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty("gender")]
    public Gender Gender { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("player_id")]
    public int PlayerID { get; set; }

    [JsonProperty("status")]
    public Status Status { get; set; }
}

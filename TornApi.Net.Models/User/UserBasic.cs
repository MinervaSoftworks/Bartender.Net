using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class UserBasic {
    [JsonIgnore]
    public int ID { get; set; }
    
    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("gender")]
    public string Gender { get; set; }

    [JsonProperty("player_id")]
    public int PlayerId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("status")]
    public Status Status { get; set; }
}

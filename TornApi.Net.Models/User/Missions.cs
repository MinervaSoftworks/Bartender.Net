using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Missions {
    [JsonProperty("Duke")]
    public List<Mission> Duke { get; set; }
}

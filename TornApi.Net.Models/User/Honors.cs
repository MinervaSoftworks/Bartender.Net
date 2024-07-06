using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Honors {
    [JsonProperty("honors_awarded")]
    public List<int> HonorsAwarded { get; set; }

    [JsonProperty("honors_time")]
    public List<int> HonorsTime { get; set; }
}


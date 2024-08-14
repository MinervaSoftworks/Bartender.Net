using Newtonsoft.Json;

namespace Bartender.Net.User.Honors;

public class UserHonors {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("honors_awarded")]
    public List<int> HonorsAwarded { get; set; }

    [JsonProperty ("honors_time")]
    public List<int> HonorsTime { get; set; }
}


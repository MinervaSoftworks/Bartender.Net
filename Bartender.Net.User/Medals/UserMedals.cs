using Newtonsoft.Json;

namespace Bartender.Net.User.Medals;

public class UserMedals {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("medals_awarded")]
    public List<int> MedalsAwarded { get; set; }

    [JsonProperty ("medals_time")]
    public List<int> MedalsTime { get; set; }
}
using Newtonsoft.Json;

namespace Bartender.Net.User.Medals;

public class UserMedals {
    [JsonProperty ("medals_awarded")]
    public required IEnumerable<int> MedalsAwarded { get; set; }

    [JsonProperty ("medals_time")]
    public required IEnumerable<int> MedalsTime { get; set; }
}
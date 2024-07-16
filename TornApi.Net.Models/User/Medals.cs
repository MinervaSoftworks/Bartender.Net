using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Medals {
    [JsonProperty("medals_awarded")]
    public IEnumerable<int> MedalsAwarded { get; set; }

    [JsonProperty("medals_time")]
    public IEnumerable<int> MedalsTime { get; set; }
}
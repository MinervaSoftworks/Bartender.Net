using Newtonsoft.Json;

namespace TornApi.Net.Models.Common;

public class Timestamp {
    [JsonProperty("timestamp")]
    public int Value { get; set; }
}

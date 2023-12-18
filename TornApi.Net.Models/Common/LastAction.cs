using Newtonsoft.Json;

namespace TornApi.Net.Models.Common;

public class LastAction {
    [JsonProperty("relative")]
    public string Relative { get; set; }

    [JsonProperty("status")]
    public LastActionStatus Status { get; set; }

    [JsonProperty("timestamp")]
    public long? Timestamp { get; set; }
}

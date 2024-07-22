using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class LastAction {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("relative")]
    public required string Relative { get; set; }

    [JsonProperty ("status")]
    public required LastActionStatus Status { get; set; }

    [JsonProperty ("timestamp")]
    public required long? Timestamp { get; set; }
}

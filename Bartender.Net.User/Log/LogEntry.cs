using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class LogEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("category")]
    public required string Category { get; set; }

    [JsonProperty ("data")]
    public required Dictionary<string, int> Data { get; set; }

    [JsonProperty ("log")]
    public required string LogType { get; set; }

    [JsonProperty ("params")]
    public required Dictionary<string, string> Params { get; set; }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }
}

using Bartender.Net.Framework.User.Log;
using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class LogEntry : ILogEntry {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("category")]
    public required string Category { get; set; }

    [JsonProperty ("data")]
    public required IDictionary<string, int> Data { get; set; }

    [JsonProperty ("log")]
    public required string LogType { get; set; }

    [JsonProperty ("params")]
    public required IDictionary<string, string> Params { get; set; }

    [JsonProperty ("timestamp")]
    public required long Timestamp { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }
}

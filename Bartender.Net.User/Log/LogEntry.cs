using Bartender.Net.Framework.User.Log;
using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class LogEntry : ILogEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("category")]
    public string Category { get; set; }

    [JsonProperty ("data")]
    public IDictionary<string, int> Data { get; set; }

    [JsonProperty ("log")]
    public string LogType { get; set; }

    [JsonProperty ("params")]
    public IDictionary<string, string> Params { get; set; }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }

    [JsonProperty ("title")]
    public string Title { get; set; }
}

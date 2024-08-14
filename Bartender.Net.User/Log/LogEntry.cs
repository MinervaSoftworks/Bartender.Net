using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class LogEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("category")]
    public string Category { get; set; }

    [JsonProperty ("data")]
    public Dictionary<string, int> Data { get; set; }

    [JsonProperty ("log")]
    public string LogType { get; set; }

    [JsonProperty ("params")]
    public Dictionary<string, string> Params { get; set; }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }

    [JsonProperty ("title")]
    public string Title { get; set; }
}

using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Log {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public string LogID { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("data")]
    public IDictionary<string, int> Data { get; set; }

    [JsonProperty("params")]
    public IDictionary<string, string> Params { get; set; }

    [JsonProperty("timestamp")]
    public long Timestamp { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}

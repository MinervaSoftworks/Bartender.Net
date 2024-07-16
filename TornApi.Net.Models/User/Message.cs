using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Message {
    [JsonProperty("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("seen")]
    public int Seen { get; set; }

    [JsonProperty("read")]
    public int Read { get; set; }
}

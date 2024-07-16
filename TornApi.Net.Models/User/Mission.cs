using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Mission {
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }
}

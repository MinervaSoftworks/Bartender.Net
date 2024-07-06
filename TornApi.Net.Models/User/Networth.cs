using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Networth {
    [JsonProperty("value")]
    public int Value { get; set; }

    [JsonProperty("rank")]
    public int Rank { get; set; }
}


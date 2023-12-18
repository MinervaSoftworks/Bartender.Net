using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Competition {
    [JsonProperty ("attacks")]
    public int Attacks { get; set; }

    [JsonProperty ("image")]
    public string Image { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public object Position { get; set; }

    [JsonProperty ("score")]
    public float Score { get; set; }

    [JsonProperty ("team")]
    public string Team { get; set; }

    [JsonProperty ("text")]
    public string Text { get; set; }

    [JsonProperty ("total")]
    public int Total { get; set; }

    [JsonProperty ("treats_collected_total")]
    public int TreatsCollectedTotal { get; set; }

    [JsonProperty ("votes")]
    public int Votes { get; set; }
}

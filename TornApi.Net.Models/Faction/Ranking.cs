using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class Ranking {
    [JsonIgnore]
    public int ID { get; set; }

    public int RankingID { get; set; }

    public Basic Faction { get; set; }

    [JsonProperty ("division")]
    public int Division { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("name")]
    public Rank Rank { get; set; }

    [JsonProperty ("position")]
    public int Position { get; set; }

    [JsonProperty ("wins")]
    public int Wins { get; set; }
}

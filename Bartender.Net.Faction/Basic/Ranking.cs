using Bartender.Net.Extensions;
using Bartender.Net.Framework.Faction.Basic;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class Ranking : IRanking {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("division")]
    public int Division { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("name")]
    public string RankString { get; set; }

    [JsonIgnore]
    public Rank Rank {
        get => RankString.ToRank ();
        set => RankString = value.ToString ();
    }

    [JsonProperty ("position")]
    public int Position { get; set; }

    [JsonProperty ("wins")]
    public int Wins { get; set; }
}

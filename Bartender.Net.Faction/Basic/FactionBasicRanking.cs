using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Faction.Basic;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionBasicRanking : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("division")]
    public required int Division { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string RankString { get; set; }

    [JsonIgnore]
    public Rank Rank {
        get => RankString.ToRank ();
        set => RankString = value.ToString ();
    }

    [JsonProperty ("position")]
    public required int Position { get; set; }

    [JsonProperty ("wins")]
    public required int Wins { get; set; }
}

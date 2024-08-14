using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionBasic {
    [JsonProperty ("age")]
    public required int Age { get; set; }

    [JsonProperty ("best_chain")]
    public required int BestChain { get; set; }

    [JsonProperty ("capacity")]
    public required int Capacity { get; set; }

    [JsonProperty ("co-leader")]
    public required int ColeaderID { get; set; }

    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("leader")]
    public required int Leader { get; set; }

    [JsonProperty ("members")]
    public required Dictionary<string, FactionMember> Members { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("peace")]
    public required Dictionary<string, long> PeaceTreaties { get; set; }

    [JsonProperty ("raid_wars")]
    public required List<Raid> RaidWars { get; set; }

    [JsonProperty ("rank")]
    public Ranking Rank { get; set; }

    [JsonProperty ("ranked_wars")]
    public required Dictionary<string, RankedWar> RankedWars { get; set; }

    [JsonProperty ("respect")]
    public required int Respect { get; set; }

    [JsonProperty ("tag")]
    public required string Tag { get; set; }

    [JsonProperty ("tag_image")]
    public required string TagImage { get; set; }

    [JsonProperty ("territory_wars")]
    public required List<TerritoryWar> TerritoryWars { get; set; }
}

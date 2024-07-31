using Bartender.Net.Framework.Faction.Basic;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionBasic : IFactionBasic {
    [JsonProperty ("age")]
    public int Age { get; set; }

    [JsonProperty ("best_chain")]
    public int BestChain { get; set; }

    [JsonProperty ("capacity")]
    public int Capacity { get; set; }

    [JsonProperty ("co-leader")]
    public int ColeaderID { get; set; }

    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("leader")]
    public int Leader { get; set; }

    [JsonProperty ("members")]
    public IDictionary<string, IFactionMember> Members { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("peace")]
    public IDictionary<string, long> PeaceTreaties { get; set; }

    [JsonProperty ("raid_wars")]
    public IEnumerable<IRaid> RaidWars { get; set; }

    [JsonProperty ("rank")]
    public IRanking Rank { get; set; }

    [JsonProperty ("ranked_wars")]
    public IDictionary<string, IRankedWar> RankedWars { get; set; }

    [JsonProperty ("respect")]
    public int Respect { get; set; }

    [JsonProperty ("tag")]
    public string Tag { get; set; }

    [JsonProperty ("tag_image")]
    public string TagImage { get; set; }

    [JsonProperty ("territory_wars")]
    public IEnumerable<ITerritoryWar> TerritoryWars { get; set; }
}

using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Basic;

public class FactionBasic : BartenderEntity {
    [JsonProperty ("age")]
    public required int Age { get; set; }

    [JsonProperty ("best_chain")]
    public required int BestChain { get; set; }

    [JsonProperty ("capacity")]
    public required int Capacity { get; set; }

    [JsonProperty ("co-leader")]
    public required int ColeaderID { get; set; }

    [JsonProperty ("ID")]
    public required int FactionID { get; set; }

    [JsonProperty ("leader")]
    public required int Leader { get; set; }

    [JsonProperty ("members")]
    [NotMapped]
    public Dictionary<string, FactionBasicMember> Members { get; set; } = default!;

    public virtual List<FactionBasicMember> MembersList {
        get => Members.TornDictionaryToList ();
        set => Members = value.ToTornDictionary ();
    }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("peace")]
    [NotMapped]
    public Dictionary<string, long> PeaceTreaties { get; set; } = default!;

    [JsonProperty ("raid_wars")]
    [NotMapped]
    public virtual required Dictionary<string, FactionBasicRaid> RaidWars { get; set; }

    public virtual List<FactionBasicRaid> RaidWarsList {
        get => RaidWars.TornDictionaryToList ();
        set => RaidWars = value.ToTornDictionary ();
    }

    [JsonProperty ("rank")]
    public virtual required FactionBasicRanking Rank { get; set; }

    [JsonProperty ("ranked_wars")]
    [NotMapped]
    public Dictionary<string, FactionBasicRankedWar> RankedWars { get; set; } = default!;

    public virtual List<FactionBasicRankedWar> RankedWarsList {
        get => RankedWars.TornDictionaryToList ();
        set => RankedWars = value.ToTornDictionary ();
    }

    [JsonProperty ("respect")]
    public required int Respect { get; set; }

    [JsonProperty ("tag")]
    public required string Tag { get; set; }

    [JsonProperty ("tag_image")]
    public required string TagImage { get; set; }

    [JsonProperty ("territory_wars")]
    [NotMapped]
    public virtual required Dictionary<string, FactionBasicTerritoryWar> TerritoryWars { get; set; }

    public virtual required List<FactionBasicTerritoryWar> TerritoryWarsList {
        get => TerritoryWars.TornDictionaryToList ();
        set => TerritoryWars = value.ToTornDictionary ();
    }
}

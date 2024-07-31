using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Faction.Basic;

public interface IFactionBasic : IBartenderEntity {
    int Age { get; set; }
    int BestChain { get; set; }
    int Capacity { get; set; }
    int ColeaderID { get; set; }
    int Leader { get; set; }
    IDictionary<string, IStatus> Members { get; set; }
    string Name { get; set; }
    IDictionary<string, long> PeaceTreaties { get; set; }
    IEnumerable<IRaid> RaidWars { get; set; }
    IRanking Rank { get; set; }
    IDictionary<string, IRankedWar> RankedWars { get; set; }
    int Respect { get; set; }
    string Tag { get; set; }
    string TagImage { get; set; }
    IEnumerable<ITerritoryWar> TerritoryWars { get; set; }
}

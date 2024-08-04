namespace Bartender.Net.Framework.Faction.Basic;

public interface IFactionBasic : IBartenderEntity {
    int Age { get; }
    int BestChain { get; }
    int Capacity { get; }
    int ColeaderID { get; }
    int Leader { get; }
    IDictionary<string, IFactionMember> Members { get; }
    string Name { get; }
    IDictionary<string, long> PeaceTreaties { get; }
    IEnumerable<IRaid> RaidWars { get; }
    IRanking Rank { get; }
    IDictionary<string, IRankedWar> RankedWars { get; }
    int Respect { get; }
    string Tag { get; }
    string TagImage { get; }
    IEnumerable<ITerritoryWar> TerritoryWars { get; }
}

namespace Bartender.Net.Framework.Faction.Basic;

public interface IRanking : IBartenderEntity {
    int Division { get; }
    int Level { get; }
    int Position { get; }
    Rank Rank { get; }
    string RankString { get; }
    int Wins { get; }
}

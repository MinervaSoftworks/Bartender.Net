namespace Bartender.Net.Framework.Faction.Basic;

public interface IRanking : IBartenderEntity {
    int Division { get; set; }
    int Level { get; set; }
    int Position { get; set; }
    Rank Rank { get; set; }
    string RankString { get; set; }
    int Wins { get; set; }
}

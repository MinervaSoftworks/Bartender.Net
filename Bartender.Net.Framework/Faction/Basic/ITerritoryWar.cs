namespace Bartender.Net.Framework.Faction.Basic;

public interface ITerritoryWar : IBartenderEntity {
    int AssaultingFaction { get; }
    int DefendingFaction { get; }
    long EndTime { get; }
    int RequiredScore { get; }
    int Score { get; }
    long StartTime { get; }
    string Territory { get; }
    int TerritoryWarID { get; }
}

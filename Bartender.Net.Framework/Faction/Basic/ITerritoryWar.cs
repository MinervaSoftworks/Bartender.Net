namespace Bartender.Net.Framework.Faction.Basic;

public interface ITerritoryWar : IBartenderEntity {
    int AssaultingFaction { get; set; }
    int DefendingFaction { get; set; }
    long EndTime { get; set; }
    int RequiredScore { get; set; }
    int Score { get; set; }
    long StartTime { get; set; }
    string Territory { get; set; }
    int TerritoryWarID { get; set; }
}

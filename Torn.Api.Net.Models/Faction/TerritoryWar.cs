namespace Torn.Api.Net.Models.Faction;

public class TerritoryWar {
    public int AssaultingFaction { get; set; }

    public int DefendingFaction { get; set; }

    public long EndTime { get; set; }

    public int RequiredScore { get; set; }

    public int Score { get; set; }

    public long StartTime { get; set; }

    public string Territory { get; set; }

    public int TerritoryWarID { get; set; }
}

namespace Bartender.Net.Framework.Faction.Basic;

public interface IRaid : IBartenderEntity {
    int DefenderFaction { get; set; }
    int DefenderScore { get; set; }
    int RaiderFaction { get; set; }
    string RaiderScore { get; set; }
    long StartTime { get; set; }
}

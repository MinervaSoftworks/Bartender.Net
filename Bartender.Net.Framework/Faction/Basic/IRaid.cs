namespace Bartender.Net.Framework.Faction.Basic;

public interface IRaid : IBartenderEntity {
    int DefenderFaction { get; }
    int DefenderScore { get; }
    int RaiderFaction { get; }
    string RaiderScore { get; }
    long StartTime { get; }
}

namespace Bartender.Net.Framework.Faction.ChainReport;

public interface IChainParticipant : IBartenderEntity {
    int Assist { get; }
    int Attacks { get; }
    int Avg { get; }
    int Best { get; }
    int Bonus { get; }
    int Draw { get; }
    int Escape { get; }
    int FactionID { get; }
    int Hosp { get; }
    int Leave { get; }
    int Level { get; }
    int Loss { get; }
    int Mug { get; }
    int Overseas { get; }
    int Respect { get; }
    int Retal { get; }
    int War { get; }
}

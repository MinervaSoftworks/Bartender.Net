namespace Bartender.Net.Framework.Faction.ChainReport;

public interface IChainParticipant : IBartenderEntity {
    int Assist { get; set; }
    int Attacks { get; set; }
    int Avg { get; set; }
    int Best { get; set; }
    int Bonus { get; set; }
    int Draw { get; set; }
    int Escape { get; set; }
    int FactionID { get; set; }
    int Hosp { get; set; }
    int Leave { get; set; }
    int Level { get; set; }
    int Loss { get; set; }
    int Mug { get; set; }
    int Overseas { get; set; }
    int Respect { get; set; }
    int Retal { get; set; }
    int War { get; set; }
}

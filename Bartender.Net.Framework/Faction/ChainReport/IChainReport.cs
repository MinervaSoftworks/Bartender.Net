namespace Bartender.Net.Framework.Faction.ChainReport;

public interface IChainReport : IBartenderEntity {
    int Assists { get; set; }
    int Besthit { get; set; }
    List<IBonusHit> Bonuses { get; set; }
    int Chain { get; set; }
    int Draws { get; set; }
    int End { get; set; }
    int Escapes { get; set; }
    int FactionID { get; set; }
    int Hospitalize { get; set; }
    int Leave { get; set; }
    int Losses { get; set; }
    int Mug { get; set; }
    int Overseas { get; set; }
    IDictionary<string, IChainParticipant> Participants { get; set; }
    double Respect { get; set; }
    int Retaliations { get; set; }
    int Start { get; set; }
    int Targets { get; set; }
    int Warhits { get; set; }
}

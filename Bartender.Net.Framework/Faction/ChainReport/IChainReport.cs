namespace Bartender.Net.Framework.Faction.ChainReport;

public interface IChainReport : IBartenderEntity {
    int Assists { get; }
    int Besthit { get; }
    List<IBonusHit> Bonuses { get; }
    int Chain { get; }
    int Draws { get; }
    int End { get; }
    int Escapes { get; }
    int FactionID { get; }
    int Hospitalize { get; }
    int Leave { get; }
    int Losses { get; }
    int Mug { get; }
    int Overseas { get; }
    IDictionary<string, IChainParticipant> Participants { get; }
    double Respect { get; }
    int Retaliations { get; }
    int Start { get; }
    int Targets { get; }
    int Warhits { get; }
}

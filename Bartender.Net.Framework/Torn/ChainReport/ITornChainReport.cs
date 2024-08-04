namespace TornApi.Net.Models.Torn;

public interface ITornChainReport {
    int Assists { get; }
    int BestHit { get; }
    IList<IChainBonues> Bonuses { get; }
    int Draws { get; }
    long End { get; }
    int Escapes { get; }
    int FactionID { get; }
    int Leave { get; }
    int Losses { get; }
    int Mug { get; }
    int Overseas { get; }
    double Respect { get; }
    int Retaliations { get; }
    long Start { get; }
    int Targets { get; }
    int WarHits { get; }
    IDictionary<string, IChainMemeber> Members { get; }
}

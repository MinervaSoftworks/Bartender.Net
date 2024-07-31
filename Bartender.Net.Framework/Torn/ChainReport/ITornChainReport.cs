namespace TornApi.Net.Models.Torn;

public interface ITornChainReport {
    int Assists { get; set; }
    int BestHit { get; set; }
    IList<IChainBonues> Bonuses { get; set; }
    int Draws { get; set; }
    long End { get; set; }
    int Escapes { get; set; }
    int FactionID { get; set; }
    int Leave { get; set; }
    int Losses { get; set; }
    int Mug { get; set; }
    int Overseas { get; set; }
    double Respect { get; set; }
    int Retaliations { get; set; }
    long Start { get; set; }
    int Targets { get; set; }
    int WarHits { get; set; }
    IDictionary<string, IChainMemeber> Members { get; set; }
}

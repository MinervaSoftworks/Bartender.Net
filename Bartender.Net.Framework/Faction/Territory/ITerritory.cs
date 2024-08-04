using Bartender.Net.Framework;

namespace Bartender.Net.Faction.Territory;

public interface ITerritory : IBartenderEntity {
    string CoordinateX { get; }
    string CoordinateY { get; }
    int DailyRespect { get; }
    int Density { get; }
    int Faction { get; }
    IRacket Racket { get; }
    int Sector { get; }
    int Size { get; }
    int Slots { get; }
}

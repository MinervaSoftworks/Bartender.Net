using Bartender.Net.Framework;

namespace Bartender.Net.Faction.Territory;

public interface ITerritory : IBartenderEntity {
    string CoordinateX { get; set; }
    string CoordinateY { get; set; }
    int DailyRespect { get; set; }
    int Density { get; set; }
    int Faction { get; set; }
    IRacket Racket { get; set; }
    int Sector { get; set; }
    int Size { get; set; }
    int Slots { get; set; }
}

using Bartender.Net.Framework;

namespace Bartender.Net.Faction.RankedWars;

public interface IRankedWar : IBartenderEntity {
    int End { get; set; }
    int Start { get; set; }
    int Target { get; set; }
    int Winner { get; set; }
}

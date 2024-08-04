using Bartender.Net.Framework;

namespace Bartender.Net.Faction.RankedWars;

public interface IRankedWar : IBartenderEntity {
    int End { get; }
    int Start { get; }
    int Target { get; }
    int Winner { get; }
}

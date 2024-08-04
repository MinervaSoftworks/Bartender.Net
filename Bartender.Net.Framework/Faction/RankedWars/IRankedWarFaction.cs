using Bartender.Net.Framework;

namespace Bartender.Net.Faction.RankedWars;

public interface IRankedWarFaction : IBartenderEntity {
    int Chain { get; }
    int Name { get; }
    int Score { get; }
}

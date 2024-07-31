using Bartender.Net.Framework;

namespace Bartender.Net.Faction.RankedWars;

public interface IRankedWarFaction : IBartenderEntity {
    int Chain { get; set; }
    int Name { get; set; }
    int Score { get; set; }
}

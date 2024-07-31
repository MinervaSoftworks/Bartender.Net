using Bartender.Net.Framework;

namespace Bartender.Net.Faction.RankedWars;

public interface IRankedWarEntry : IBartenderEntity {
    IDictionary<string, IRankedWarFaction> Factions { get; set; }
    IRankedWar Rankedwar { get; set; }
}

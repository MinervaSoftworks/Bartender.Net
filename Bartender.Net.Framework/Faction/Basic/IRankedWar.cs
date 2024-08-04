namespace Bartender.Net.Framework.Faction.Basic;

public interface IRankedWar : IBartenderEntity {
    IDictionary<string, IRankedWarFaction> Factions { get; }
    IWar War { get; }
}
namespace Bartender.Net.Framework.Faction.Basic;

public interface IRankedWar : IBartenderEntity {
    IDictionary<string, IRankedWarFaction> Factions { get; set; }
    IWar War { get; set; }
}
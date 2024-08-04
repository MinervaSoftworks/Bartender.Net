namespace Bartender.Net.Framework.Faction.Basic;

public interface IRankedWarFaction : IBartenderEntity {
    int Chain { get; }
    string Name { get; }
    int Score { get; }
}

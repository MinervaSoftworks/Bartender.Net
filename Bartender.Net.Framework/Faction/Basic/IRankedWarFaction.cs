namespace Bartender.Net.Framework.Faction.Basic;

public interface IRankedWarFaction : IBartenderEntity {
    int Chain { get; set; }
    string Name { get; set; }
    int Score { get; set; }
}

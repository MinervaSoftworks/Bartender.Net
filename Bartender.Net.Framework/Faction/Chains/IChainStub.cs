namespace Bartender.Net.Framework.Faction.Chains;

public interface IChainStub : IBartenderEntity {
    int Chain { get; set; }
    int End { get; set; }
    string Respect { get; set; }
    int Start { get; set; }
}
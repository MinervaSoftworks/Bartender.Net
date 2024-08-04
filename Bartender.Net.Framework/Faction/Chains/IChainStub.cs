namespace Bartender.Net.Framework.Faction.Chains;

public interface IChainStub : IBartenderEntity {
    int Chain { get; }
    int End { get; }
    string Respect { get; }
    int Start { get; }
}
namespace Bartender.Net.Framework.Faction.Chains;

public interface IFactionChainStubs {
    IDictionary<string, IChainStub> Chains { get; }
}

namespace Bartender.Net.Framework.Faction.Chain;

public interface ICurrentChainEntry : IBartenderEntity {
    int Cooldown { get; }
    int Current { get; }
    int End { get; }
    int Max { get; }
    int Modifier { get; }
    int Start { get; }
    int Timeout { get; }
}

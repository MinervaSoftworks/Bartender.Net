namespace Bartender.Net.Framework.Faction.Chain;

public interface ICurrentChainEntry : IBartenderEntity {
    int Cooldown { get; set; }
    int Current { get; set; }
    int End { get; set; }
    int Max { get; set; }
    int Modifier { get; set; }
    int Start { get; set; }
    int Timeout { get; set; }
}

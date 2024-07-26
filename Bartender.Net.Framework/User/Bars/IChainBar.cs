namespace Bartender.Net.Framework.User.Bars;

public interface IChainBar : IBartenderEntity {
    int Cooldown { get; }
    int Current { get; }
    int Maximum { get; }
    float Modifier { get; }
    int Timeout { get; }
}
namespace Bartender.Net.Framework.User.Bars;

public interface IChainBar : IBartenderEntity {
    int Cooldown { get; set; }
    int Current { get; set; }
    int Maximum { get; set; }
    float Modifier { get; set; }
    int Timeout { get; set; }
}
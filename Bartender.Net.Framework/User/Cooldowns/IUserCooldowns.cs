namespace Bartender.Net.Framework.User.Cooldowns;

public interface IUserCooldowns : IBartenderEntity {
    int Booster { get; }
    int Drug { get; }
    int Medical { get; }
}
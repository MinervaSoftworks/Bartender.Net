namespace Bartender.Net.Framework.User.Cooldowns;

public interface IUserCooldowns {
    int Booster { get; set; }
    int Drug { get; set; }
    int Medical { get; set; }
}
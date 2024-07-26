namespace Bartender.Net.Framework.User.Cooldowns;

public interface IUserCooldownsCollection {
    IUserCooldowns Cooldowns { get; }
}
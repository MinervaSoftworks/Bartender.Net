namespace Bartender.Net.Framework.User.Notifications;

public interface IUserNotificationsRoot {
    IUserNotifications Notifications { get; }
}
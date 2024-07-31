namespace Bartender.Net.Framework.User.Notifications;

public interface IUserNotifications : IBartenderEntity {
    int Awards { get; }
    int Competition { get; }
    int Events { get; }
    int Messages { get; }
}
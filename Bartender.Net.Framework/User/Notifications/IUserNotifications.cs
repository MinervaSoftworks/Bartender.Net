namespace Bartender.Net.Framework.User.Notifications; 

public interface IUserNotifications : IBartenderEntity {
    int Awards { get; set; }
    int Competition { get; set; }
    int Events { get; set; }
    int Messages { get; set; }
}
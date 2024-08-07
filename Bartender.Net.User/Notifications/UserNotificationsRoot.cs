using Bartender.Net.Framework;
using Bartender.Net.Framework.User.Notifications;
using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotificationsRoot : IUserNotificationsRoot {
    [JsonProperty ("notifications")]
    [JsonConverter (typeof (ConcreteConverter<UserNotifications>))]
    public required IUserNotifications Notifications { get; set; }
}
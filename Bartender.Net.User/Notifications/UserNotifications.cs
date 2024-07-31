using Bartender.Net.Framework.User.Notifications;
using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotifications : IUserNotifications {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("messages")]
    public int Messages { get; set; }

    [JsonProperty ("events")]
    public int Events { get; set; }

    [JsonProperty ("awards")]
    public int Awards { get; set; }

    [JsonProperty ("competition")]
    public int Competition { get; set; }
}

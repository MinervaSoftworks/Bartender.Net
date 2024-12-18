using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotifications : BartenderEntity {
    [JsonProperty ("messages")]
    public required int Messages { get; set; }

    [JsonProperty ("events")]
    public required int Events { get; set; }

    [JsonProperty ("awards")]
    public required int Awards { get; set; }

    [JsonProperty ("competition")]
    public required int Competition { get; set; }
}

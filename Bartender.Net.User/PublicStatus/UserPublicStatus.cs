using Bartender.Net.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.PublicStatus;

public class UserPublicStatus {
    [JsonProperty("baned")]
    public required bool Banned { get; set; }

    [JsonProperty("playername")]
    public required string PlayerName { get; set; }

    [JsonProperty("status")]
    public required TornRole status { get; set; }

    [JsonProperty("userID")]
    public required int UserID { get; set; }
}


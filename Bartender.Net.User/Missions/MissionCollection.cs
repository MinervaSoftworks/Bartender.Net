using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class MissionCollection {
    [JsonProperty ("Duke")]
    public required List<UserMission> Duke { get; set; }
}

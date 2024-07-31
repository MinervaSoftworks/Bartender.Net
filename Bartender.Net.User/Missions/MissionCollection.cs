using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class MissionCollection {
    [JsonProperty ("Duke")]
    public List<UserMission> Duke { get; set; }
}

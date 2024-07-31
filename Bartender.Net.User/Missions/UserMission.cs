using Bartender.Net.Framework.User.Missions;
using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class UserMission : IUserMission {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("title")]
    public string Title { get; set; }

    [JsonProperty ("status")]
    public string Status { get; set; }
}

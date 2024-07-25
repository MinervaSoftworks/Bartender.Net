using Bartender.Net.Framework.User.Missions;
using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class UserMission : IUserMission{
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }
}

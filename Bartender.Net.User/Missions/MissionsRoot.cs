using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class MissionsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("Duke")]
    public virtual required List<Mission> Duke { get; set; }
}

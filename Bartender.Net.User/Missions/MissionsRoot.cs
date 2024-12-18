using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class MissionsRoot : BartenderEntity {
    [JsonProperty ("Duke")]
    public virtual required List<Mission> Duke { get; set; }
}

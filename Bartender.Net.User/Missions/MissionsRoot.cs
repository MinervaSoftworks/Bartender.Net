using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class MissionsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("Duke")]
    public virtual required List<Mission> Duke { get; set; }
}

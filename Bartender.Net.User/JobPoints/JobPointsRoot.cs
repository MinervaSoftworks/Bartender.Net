using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("jobpoints")]
    public virtual required JobPointsCollection Points { get; set; }
}

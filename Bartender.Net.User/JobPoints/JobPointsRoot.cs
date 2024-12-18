using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsRoot : BartenderEntity {
    [JsonProperty ("jobpoints")]
    public virtual required JobPointsCollection Points { get; set; }
}

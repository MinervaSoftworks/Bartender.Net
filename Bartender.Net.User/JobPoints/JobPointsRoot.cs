using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsRoot {
    [JsonProperty ("jobpoints")]
    public required JobPointsCollection Points { get; set; }
}

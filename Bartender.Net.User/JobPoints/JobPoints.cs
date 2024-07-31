using Bartender.Net.Framework.User.JobPoints;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPoints : IJobPoints {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("jobpoints")]
    public JobPointsCollection Points { get; set; }
}

using Bartender.Net.Framework.User.JobPoints;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection : IJobPointsCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("companies")]
    public required IDictionary<string, CompanyPoints> MyProperty { get; set; }

    [JsonProperty ("jobs")]
    public required UserJobPoints JobPoints { get; set; }
}

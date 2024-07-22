using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection {
    [JsonProperty("companies")]
    public required IDictionary<string, CompanyPoints> MyProperty { get; set; }

    [JsonProperty("jobs")]
    public required UserJobPoints JobPoints { get; set; }
}

public class JobPoints {
    [JsonProperty("jobpoints")]
    public required JobPointsCollection Points { get; set; }
}

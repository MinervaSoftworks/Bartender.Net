using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("companies")]
    public required Dictionary<string, CompanyPoints> Companies { get; set; }

    [JsonProperty ("jobs")]
    public required UserJobPoints JobPoints { get; set; }
}

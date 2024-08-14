using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("companies")]
    public Dictionary<string, CompanyPoints> Companies { get; set; }

    [JsonProperty ("jobs")]
    public UserJobPoints JobPoints { get; set; }
}

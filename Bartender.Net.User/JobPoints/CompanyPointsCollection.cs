using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class CompanyPointsCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("companies")]
    public required Dictionary<string, CompanyPoints> CompanyPoints { get; set; }
}

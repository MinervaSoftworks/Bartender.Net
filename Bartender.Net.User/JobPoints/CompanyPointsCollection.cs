using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class CompanyPointsCollection {
    [JsonProperty("companies")]
    public required IDictionary<string, CompanyPoints> CompanyPoints { get; set; }
}
